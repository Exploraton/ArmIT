/*
 * Created by SharpDevelop.
 * User: Play
 * Date: 11/06/2013
 * Time: 11:26
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace arm
{
	/// <summary>
	/// Description of ColumnSelectionForm.
	/// </summary>
	public partial class ColumnSelectionForm : Form
	{
		private DataManager dataManager;
		
		public ColumnSelectionForm(ColumnHeaders headers, DataManager dataManager)
		{
			// The InitializeComponent() call is required for Windows Forms designer support.
			InitializeComponent();
			
			// TODO: Add constructor code after the InitializeComponent() call.
			this.dataManager = dataManager;
			SelectionCheckedListBox.DataSource = headers.ColumnTranslations;
			
			ReadAllProperties();
		}

		void ButtonDoneClick(object sender, System.EventArgs e)
		{
			DialogResult = DialogResult.OK;
			SaveAllProperties();
		}
	
		public bool IsSelected(int idx)
		{
			return SelectionCheckedListBox.GetItemChecked(idx);
		}
		
		private void ReadAllProperties()
		{
			string visibilityState = dataManager.GetProperty("ColumnVisibility" );
			
			if (visibilityState==null || visibilityState.Length<10)
				visibilityState="TTTTTTTTTT";
			    
			bool visible;
			for(int idx=0; idx<SelectionCheckedListBox.Items.Count; ++idx)
			{
				if (idx >= visibilityState.Length )
					visible = true;
				else
					visible = visibilityState[idx]!='F';
				SelectionCheckedListBox.SetItemChecked(idx, visible);
			}
		}
		
		private void SaveAllProperties()
		{
			string visibilityStates="";
			for(int idx=0; idx<SelectionCheckedListBox.Items.Count; ++idx)
				 visibilityStates += IsSelected(idx)?"T":"F";
			
			dataManager.SetProperty("ColumnVisibility", visibilityStates );
		}
	}
}
