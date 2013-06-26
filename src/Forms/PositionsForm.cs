/*
 * Created by SharpDevelop.
 * User: Play
 * Date: 13/06/2013
 * Time: 13:46
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace arm
{
	
	/// <summary>
	/// Description of PositionsForm.
	/// </summary>
	public partial class PositionsForm : Form
	{
		public PositionsForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			string xml = DataManager.Singleton.GetProperty("Hierarchy");
			LoadHierarchy(xml);
		}
		
		void ButtonSaveClick(object sender, EventArgs e)
		{
			SaveHierarchy();
			DialogResult = DialogResult.OK;
		}
				
		void ButtonCancelClick(object sender, EventArgs e)
		{
			// discard changes and restore hierarchy from DB
			//string xml = DataManager.Singleton.GetProperty("Hierarchy");
			//LoadHierarchy(xml);
			DialogResult = DialogResult.Cancel;
		}

		void ButtonAddNodeClick(object sender, EventArgs e)
		{
			TreeNode selected = PositionsTreeView.SelectedNode;
			if (selected == null)
				selected = PositionsTreeView.Nodes[0];
			
			selected.Nodes.Add("Αδειο");
			selected.ExpandAll();
		}
		
		void ButtonRemoveNodeClick(object sender, EventArgs e)
		{
			TreeNode selected = PositionsTreeView.SelectedNode;
			if (selected == null)
				return;
			
			DialogResult dialogResult = MessageBox.Show("Είσαστε σίγουρος για την διαγραφή;"
			                                            , "Επιβεβαίωση"
			                                            , MessageBoxButtons.YesNo);
			if (dialogResult == DialogResult.No)
				return;
			
			if (selected==PositionsTreeView.Nodes[0])
				selected.Nodes.Clear();
			else
				selected.Remove();
		}
		
		void ButtonDuplicateClick(object sender, EventArgs e)
		{
			TreeNode selected = PositionsTreeView.SelectedNode;
			if (selected == null || selected==PositionsTreeView.Nodes[0] || selected.Parent==null)
				return;
			
			TreeNode copy = DuplicateTree(selected);
			selected.Parent.Nodes.Insert(selected.Index+1, copy);
			copy.ExpandAll();
			
		}
		
		private TreeNode DuplicateTree(TreeNode head)
		{
			TreeNode copy = new TreeNode(head.Text);
			foreach(TreeNode child in head.Nodes)
				copy.Nodes.Add( DuplicateTree(child) );
			return copy;
		}
		
		void ButtonUpClick(object sender, EventArgs e)
		{
			TreeNode selected = PositionsTreeView.SelectedNode;
			TreeNode parent = selected.Parent;
			if (selected == null || selected==PositionsTreeView.Nodes[0] || parent==null)
				return;
			
			int idx = selected.Index;
			if (idx>0)
			{
				selected.Remove();
				parent.Nodes.Insert(idx-1, selected);
				PositionsTreeView.SelectedNode = selected;
			}
		}
		
		void ButtonDownClick(object sender, EventArgs e)
		{
			TreeNode selected = PositionsTreeView.SelectedNode;
			TreeNode parent = selected.Parent;
			if (selected == null || selected==PositionsTreeView.Nodes[0] || parent==null)
				return;
			
			int idx = selected.Index;
			if (idx<parent.Nodes.Count-1)
			{
				selected.Remove();
				parent.Nodes.Insert(idx+1, selected);
				PositionsTreeView.SelectedNode = selected;
			}
		}
		
		void ButtonSaveHierarchyClick(object sender, EventArgs e)
		{
			FileDialog fileDialog = new SaveFileDialog();
			fileDialog.Filter = "xml files (*.xml)|*.xml";
			fileDialog.ShowDialog(this);

			string xmlText = TreeViewItemXmlSerializer.XmlFromTree( PositionsTreeView.Nodes[0] );
			System.IO.File.WriteAllText(fileDialog.FileName, xmlText);
		}
		
		void ButtonLoadHierarchyClick(object sender, EventArgs e)
		{
			FileDialog fileDialog = new OpenFileDialog();
			fileDialog.Filter = "xml files (*.xml)|*.xml";
			fileDialog.ShowDialog(this);

			string xml = System.IO.File.ReadAllText(fileDialog.FileName);
			LoadHierarchy(xml);
		}
		
		void LoadHierarchy(string xml)
		{
			TreeNode top=null;
			PositionsTreeView.Nodes.Clear();
			if (xml!=null && xml!=string.Empty)
			{
				try	{ top = TreeViewItemXmlSerializer.BuildTreeFromXML(xml);	}
				catch(Exception xcp)
				{
					MessageBox.Show(xcp.Message,"Error while loading hierarchy");
				}
			}
			if (top!=null)		PositionsTreeView.Nodes.Add(top);
			else				PositionsTreeView.Nodes.Add("Αδειο");
		}
		
		void SaveHierarchy()
		{
			string xmlText = TreeViewItemXmlSerializer.XmlFromTree( PositionsTreeView.Nodes[0] );

			DataManager.Singleton.SetProperty("Hierarchy", xmlText);
		}
	}
}
