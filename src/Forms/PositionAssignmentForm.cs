/*
 * Created by SharpDevelop.
 * User: Play
 * Date: 16/06/2013
 * Time: 01:19
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Xml;
using System.IO;
using SQLite;

namespace arm
{
	public partial class PositionAssignmentForm : Form
	{
		List<PositionInfo> Positions;
		List<SoldierRecord> Soldiers;
		List<SoldierRecord> UnassignedSoldiers;
		XmlDocument xmlDoc;
		
		public PositionAssignmentForm(Collection<SoldierRecord> soldiers)
		{
			// The InitializeComponent() call is required for Windows Forms designer support.
			InitializeComponent();
			
			// TODO: Add constructor code after the InitializeComponent() call.
			Soldiers = soldiers.Cast<SoldierRecord>().ToList();
			UnassignedSoldiers = soldiers.Cast<SoldierRecord>().ToList();

			string xml = DataManager.Singleton.GetProperty("Hierarchy");
			xmlDoc = new XmlDocument();
			xmlDoc.LoadXml( xml);

			Positions = ExtractPositionsList(xmlDoc);
			FillPositionsListView(Positions);

			UnassignedListBox.Items.AddRange(UnassignedSoldiers.ToArray());
		}

		void FillPositionsListView(List<PositionInfo> positions)
		{
			Dictionary<string, ListViewGroup> groupsMap = new Dictionary<string, ListViewGroup>();
			PositionsListView.BeginUpdate();
			foreach(PositionInfo pos in positions)
			{
				ListViewGroup lvgroup;
				groupsMap.TryGetValue(pos.GroupPath, out lvgroup);
				if (lvgroup==null)
				{
					lvgroup = new ListViewGroup(pos.GroupPath);
					groupsMap.Add(pos.GroupPath, lvgroup);
					PositionsListView.Groups.Add(lvgroup);
				}

				var item = new ListViewItem(pos.Name);
				item.Group = lvgroup;
				item.Tag = pos;
				if (pos.AssignedSoldier==null)
				{
					item.SubItems.Add("κενή");
					item.ImageIndex=0;
				}
				else
				{
					item.SubItems.Add( pos.AssignedSoldier.ToString());
					item.SubItems[1].Tag = pos.AssignedSoldier;
					item.ImageIndex=1;
				}
				PositionsListView.Items.Add(item);
				
			}
			PositionsListView.EndUpdate();
		}
	
		List<PositionInfo> ExtractPositionsList(XmlDocument xmlDoc)
		{
			XmlElement xmlRoot = (XmlElement) xmlDoc.GetElementsByTagName("root").Item(0);

			if (xmlRoot== null)
	       		return null;
		
			List<PositionInfo> positions = new List<PositionInfo>();
			
			List<string> groups = new List<string>();
			TraverseXmlNodes(xmlRoot, positions, groups );
			
            return positions;
		}
		
		void TraverseXmlNodes(XmlElement xmlHead, List<PositionInfo> positions, List<string> groups)
		{
			int sequence = 1;
			foreach(XmlElement xmlChild in xmlHead.ChildNodes)
			{
				string name = xmlChild.GetAttribute("t");
				if (xmlChild.ChildNodes.Count==0)
				{
					SoldierRecord assignedSoldier = FindSoldier( xmlChild.GetAttribute("soldierId") );
					positions.Add( new PositionInfo( name, groups.ToArray(), sequence, assignedSoldier, xmlChild) );
					sequence++;
					// remove from unassignedSoldiers list
					UnassignedSoldiers.Remove(assignedSoldier);
				}
				else
				{
					groups.Add(name);
					TraverseXmlNodes(xmlChild, positions, groups);
					groups.Remove(name);
				}
			}
		}
		
		SoldierRecord FindSoldier(string soldierId)
		{
			if (soldierId!=string.Empty)
			{
				int id = Convert.ToInt32(soldierId);

				if (id>0)
					return Soldiers.Find( p => { return p.Id==id; } );
			}
			return null;
		}
		
		void ButtonAssignClick(object sender, EventArgs e)
		{
			if (UnassignedListBox.SelectedItem==null ||
			    PositionsListView.SelectedItems.Count==0)
				return;
			
			SoldierRecord newSoldier = UnassignedListBox.SelectedItem as SoldierRecord;
			ListViewItem lvItem = PositionsListView.SelectedItems[0];
			SoldierRecord currentSoldier = lvItem.SubItems[1].Tag as SoldierRecord;
			
			if (currentSoldier!=null)
			{
				UnassignedListBox.Items.Add(currentSoldier);
			}
			UnassignedListBox.Items.Remove(newSoldier);
			
			lvItem.SubItems[1].Text = newSoldier.ToString();
			lvItem.SubItems[1].Tag = newSoldier;
			lvItem.ImageIndex= 1;
		}
		
		void ButtonClearPositionClick(object sender, EventArgs e)
		{
			if (PositionsListView.SelectedItems.Count==0)
				return;
			
			ListViewItem lvItem = PositionsListView.SelectedItems[0];
			SoldierRecord currentSoldier = lvItem.SubItems[1].Tag as SoldierRecord;
			
			if (currentSoldier!=null)
			{
				UnassignedListBox.Items.Add(currentSoldier);
			}
			
			lvItem.SubItems[1].Tag = null;
			lvItem.SubItems[1].Text = "κενή";
			lvItem.ImageIndex= 0;
		}

		void ButtonDoneClick(object sender, EventArgs e)
		{
			DialogResult = DialogResult.OK;
			
			// update xml
			foreach(ListViewItem item in PositionsListView.Items)
			{
				SoldierRecord soldier = item.SubItems[1].Tag as SoldierRecord;
				PositionInfo position = item.Tag as PositionInfo;
				if (soldier==null)
					position.xmlElement.SetAttribute("soldierId", "");
				else				
					position.xmlElement.SetAttribute("soldierId", soldier.Id.ToString());
			}
			StringWriter textWriter = new StringWriter();
			xmlDoc.Save(textWriter);
			textWriter.Close();
			DataManager.Singleton.SetProperty("Hierarchy", textWriter.ToString());
			
			progressBar.Maximum = Soldiers.Count+1;//UnassignedListBox.Items.Count +PositionsListView.Items.Count;
			progressBar.Value=0;
			DataManager.Singleton.BeginTransaction();
				UpdateAllSoldierPositions();
				ClearAllSoldierPositions();
			DataManager.Singleton.CommitTransaction();
		}
		
		private void UpdateAllSoldierPositions()
		{
			foreach(ListViewItem item in PositionsListView.Items)
			{
				PositionInfo position = item.Tag as PositionInfo;
				SoldierRecord soldier = item.SubItems[1].Tag as SoldierRecord;
				if (soldier!=null)
				{
					DataManager.Singleton.UpdateSoldierPosition( soldier.Id, position);
					position.CopyToSoldier(soldier);
					progressBar.Value++;
					progressBar.Refresh();
				}
				
			}
		}
		
		private void ClearAllSoldierPositions()
		{
			PositionInfo emptyPos = new PositionInfo("", new string[] {""}, 0, null, null);
			foreach(Object item in UnassignedListBox.Items)
			{
				SoldierRecord soldier = item as SoldierRecord;
				if (soldier!=null)
				{
					DataManager.Singleton.UpdateSoldierPosition( soldier.Id, emptyPos);
					emptyPos.CopyToSoldier(soldier);
					progressBar.Value++;
					progressBar.Refresh();
				}
				
			}
		}
		
		void ButtonCancelClick(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
		}
	}
}
