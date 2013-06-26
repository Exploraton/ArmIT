/*
 * Created by SharpDevelop.
 * User: Play
 * Date: 11/06/2013
 * Time: 11:26
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace arm
{
	partial class ColumnSelectionForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.SelectionCheckedListBox = new System.Windows.Forms.CheckedListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.buttonDone = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// SelectionCheckedListBox
			// 
			this.SelectionCheckedListBox.FormattingEnabled = true;
			this.SelectionCheckedListBox.Location = new System.Drawing.Point(12, 58);
			this.SelectionCheckedListBox.Name = "SelectionCheckedListBox";
			this.SelectionCheckedListBox.Size = new System.Drawing.Size(214, 244);
			this.SelectionCheckedListBox.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(214, 42);
			this.label1.TabIndex = 1;
			this.label1.Text = "Επιλέξτε ποιές στήλες να εμφανίζοντε στον πίνακα προσωπικού";
			// 
			// buttonDone
			// 
			this.buttonDone.Location = new System.Drawing.Point(58, 308);
			this.buttonDone.Name = "buttonDone";
			this.buttonDone.Size = new System.Drawing.Size(118, 32);
			this.buttonDone.TabIndex = 2;
			this.buttonDone.Text = "Κλείσιμο";
			this.buttonDone.UseVisualStyleBackColor = true;
			this.buttonDone.Click += new System.EventHandler(this.ButtonDoneClick);
			// 
			// ColumnSelectionForm
			// 
			this.AcceptButton = this.buttonDone;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(238, 352);
			this.Controls.Add(this.buttonDone);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.SelectionCheckedListBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "ColumnSelectionForm";
			this.Text = "Επιλογή στηλών";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button buttonDone;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckedListBox SelectionCheckedListBox;
		
	}
}
