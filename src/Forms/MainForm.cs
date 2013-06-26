/*
 * Created by SharpDevelop.
 * User: sotos
 * Date: 08/05/2013
 * Time: 20:21
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.IO;
using SQLite;

namespace arm
{

	public partial class MainForm : Form
	{
		public DataManager dataManager;
		private ColumnHeaders headers;
		private FieldFixtures fixtures;
		private SortableBindingList<SoldierRecord> soldiersBindingList;
		private ColumnSelectionForm columnSelectionForm;
			
		public MainForm()
		{
			InitializeComponent();
			
			// TODO: Add constructor code after the InitializeComponent() call.
			dataManager = DataManager.Singleton;
			dataManager.Initialize();
			
			headers = new ColumnHeaders();
			headers.Read();
							
			fixtures = new FieldFixtures();
			fixtures.Read();
			
			columnSelectionForm = new ColumnSelectionForm(headers, dataManager);
			
			personelGridView.AutoGenerateColumns = false;
			
			foreach(string colName in headers.headers.Keys)
			{
				int colidx = personelGridView.Columns.Add(colName, headers.Get(colName));
				personelGridView.Columns[colidx].DataPropertyName = colName;
				personelGridView.Columns[colidx].SortMode = DataGridViewColumnSortMode.Automatic;
			}

			SyncVisibleColumns();
			
			List<SoldierRecord> soldierList = dataManager.ReadSoldiers();
			soldiersBindingList = new SortableBindingList<SoldierRecord>(soldierList);
			bindingSource1.DataSource = soldiersBindingList;
		}
		
		//
		// Button event handlers
		//
		void ButtonAddNewClick(object sender, EventArgs e)
		{
			SoldierRecord newSoldier = new SoldierRecord
			{
				CreationDate = DateTime.Now,
				LastUpdateDate = DateTime.Now,
				ImerominiaGenniseos = new DateTime(1900,1,1),
			};
			
			SoldierDetailsForm form = new SoldierDetailsForm(newSoldier, fixtures);
			form.ShowDialog(this);

			if (form.DialogResult== DialogResult.OK)
			{
				dataManager.Insert(newSoldier);
				bindingSource1.Add(newSoldier);
			}
		}
		
		void ButtonDiorthosiClick(object sender, EventArgs e)
		{
			if (personelGridView.SelectedRows.Count>0)
			{
				int idx = personelGridView.SelectedRows[0].Index;
				SoldierRecord soldier = (SoldierRecord) personelGridView.SelectedRows[0].DataBoundItem;
				SoldierRecord newSoldier = new SoldierRecord( soldier );
				
				SoldierDetailsForm form = new SoldierDetailsForm(newSoldier, fixtures);
				form.ShowDialog(this);
	
				if (form.DialogResult== DialogResult.OK)
				{
					newSoldier.LastUpdateDate = DateTime.Now;
					
					dataManager.Update( newSoldier as SoldierRecord);
					soldier.CopyFrom(newSoldier);
					soldiersBindingList.ResetItem(idx);
				}
			}
		}
		
		void ButtonDeleteClick(object sender, EventArgs e)
		{
			if (personelGridView.SelectedRows.Count>0)
			{
				DialogResult dialogResult = MessageBox.Show("Είσαστε σίγουρος για την διαγραφή;"
				                                            , "Επιβεβαίωση"
				                                            , MessageBoxButtons.YesNo);
				if (dialogResult == DialogResult.No)
					return;
				
				int idx = personelGridView.SelectedRows[0].Index;
				SoldierRecord soldier = soldiersBindingList[idx];
				if (dataManager.Delete(soldier))
				{
					bindingSource1.Remove(soldier);
					if (personelGridView.SelectedRows.Count==0)
						personelGridView.ClearSelection();
				}
			}
		}
		
		void ButtonVisibleColumnsClick(object sender, EventArgs e)
		{
			columnSelectionForm.ShowDialog(this);
			
			SyncVisibleColumns();
		}
	
		void ButtonPositionsClick(object sender, EventArgs e)
		{
			PositionsForm form = new PositionsForm();
			form.ShowDialog(this);
		
		}
		
		void ButtonPositionAssignmentClick(object sender, EventArgs e)
		{
			PositionAssignmentForm form = new PositionAssignmentForm(soldiersBindingList);
			if (form.ShowDialog(this)==DialogResult.OK)
			{
				personelGridView.Refresh();
			}
		}
		
		private void SyncVisibleColumns()
		{
			for(int idx=0; idx<headers.headers.Keys.Count; ++idx)
			{
				bool isSelected = columnSelectionForm.IsSelected(idx);
				personelGridView.Columns[idx].Visible = isSelected;
			}
		}
		
	}
}
