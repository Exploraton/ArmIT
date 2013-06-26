/*
 * Created by SharpDevelop.
 * User: Play
 * Date: 10/06/2013
 * Time: 08:35
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using SQLite;

namespace arm
{
	public partial class SoldierDetailsForm : Form
	{
		public SoldierDetailsForm(SoldierRecord soldier, FieldFixtures fixtures)
		{
			// The InitializeComponent() call is required for Windows Forms designer support.
			InitializeComponent();
			
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			RecIdValueLabel.DataBindings.Add(new Binding("Text", soldier, "Id") );
			OnomaTextBox.DataBindings.Add(new Binding("Text", soldier, "Onoma") );
			EpithetoTextBox.DataBindings.Add(new Binding("Text", soldier, "Epitheto") );
			ASMTextBox.DataBindings.Add(new Binding("Text", soldier, "Asm") );
			KlasiTextBox.DataBindings.Add(new Binding("Text", soldier, "Klasi") );
			SeiraTextBox.DataBindings.Add(new Binding("Text", soldier, "Seira") );
			PolitikiTaytotitaTextBox.DataBindings.Add(new Binding("Text", soldier, "ArithmosPolitikisTaytotitas") );
			ImerominiaGeniseosDateTimePicker.DataBindings.Add(new Binding("Text", soldier, "ImerominiaGenniseos") );
						
			BathmosComboBox.DataSource = fixtures.Get("Bathmos");
			BathmosComboBox.DataBindings.Add( new Binding("Text", soldier, "Bathmos"));
			IdikotitaComboBox.DataSource = fixtures.Get("Idikotita");
			IdikotitaComboBox.DataBindings.Add( new Binding("Text", soldier, "Idikotita"));
			IneEfedrosComboBox.DataSource = fixtures.Get("IneEfedros");
			IneEfedrosComboBox.DataBindings.Add( new Binding("Text", soldier, "EinaiEfedros"));
			
			TilefonoOikiasTextBox.DataBindings.Add(new Binding("Text", soldier, "Til_oikias") );
			TilefonoErgasiasTextBox.DataBindings.Add(new Binding("Text", soldier, "Til_ergasias") );
			TilefonoKinitoTextBox.DataBindings.Add(new Binding("Text", soldier, "Til_kinito") );
			DieythinsiSpitiouTextBox.DataBindings.Add(new Binding("Text", soldier, "DieythinsiSpitiou") );
			DieythinsiErgasiasTextBox.DataBindings.Add(new Binding("Text", soldier, "DieythinsiErgasias") );

			Group1TextBox.DataBindings.Add( new Binding("Text",soldier, "Group1") );
			Group2TextBox.DataBindings.Add( new Binding("Text",soldier, "Group2") );
			Group3TextBox.DataBindings.Add( new Binding("Text",soldier, "Group3") );
			Group4TextBox.DataBindings.Add( new Binding("Text",soldier, "Group4") );
			Group5TextBox.DataBindings.Add( new Binding("Text",soldier, "Group5") );
			KathikontaTextBox.DataBindings.Add( new Binding("Text",soldier, "Kathikonta") );
			
			ArithmosOplouTextBox.DataBindings.Add(new Binding("Text", soldier, "ArithmosOplou") );
			ArithmosKsifologxisTextBox.DataBindings.Add(new Binding("Text", soldier, "ArithmosXyfoloxis") );
			AllosOplismosTextBox.DataBindings.Add(new Binding("Text", soldier, "AllosOplismos") );
			
			SxoliaTextBox.DataBindings.Add(new Binding("Text", soldier, "Sxolia") );
			LoipaStoixiaTextBox.DataBindings.Add(new Binding("Text", soldier, "LoipaStoixia") );
			CreationDateTextBox.DataBindings.Add(new Binding("Text", soldier, "CreationDate") );
			LastUpdateDateTextBox.DataBindings.Add(new Binding("Text", soldier, "LastUpdateDate") );
			
		}
		
		
		void ButtonSaveClick(object sender, EventArgs e)
		{
			DialogResult = DialogResult.OK;
			Close();
		}
		
		void ButtonCancelClick(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
			
		}
	}
}
