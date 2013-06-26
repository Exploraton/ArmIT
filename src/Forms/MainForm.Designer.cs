/*
 * Created by SharpDevelop.
 * User: sotos
 * Date: 08/05/2013
 * Time: 20:21
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace arm
{
	partial class MainForm
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
			this.components = new System.ComponentModel.Container();
			this.personelGridView = new System.Windows.Forms.DataGridView();
			this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.buttonVisibleColumns = new System.Windows.Forms.Button();
			this.buttonAddNew = new System.Windows.Forms.Button();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.buttonDiorthosi = new System.Windows.Forms.Button();
			this.buttonPositions = new System.Windows.Forms.Button();
			this.buttonPositionAssignment = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.personelGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
			this.SuspendLayout();
			// 
			// personelGridView
			// 
			this.personelGridView.AllowUserToAddRows = false;
			this.personelGridView.AllowUserToDeleteRows = false;
			this.personelGridView.AllowUserToOrderColumns = true;
			this.personelGridView.AllowUserToResizeRows = false;
			this.personelGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.personelGridView.AutoGenerateColumns = false;
			this.personelGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.personelGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.personelGridView.DataSource = this.bindingSource1;
			this.personelGridView.GridColor = System.Drawing.SystemColors.ActiveCaption;
			this.personelGridView.Location = new System.Drawing.Point(0, 0);
			this.personelGridView.Margin = new System.Windows.Forms.Padding(2);
			this.personelGridView.Name = "personelGridView";
			this.personelGridView.ReadOnly = true;
			this.personelGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.personelGridView.Size = new System.Drawing.Size(752, 281);
			this.personelGridView.TabIndex = 0;
			// 
			// buttonVisibleColumns
			// 
			this.buttonVisibleColumns.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonVisibleColumns.Location = new System.Drawing.Point(614, 299);
			this.buttonVisibleColumns.Name = "buttonVisibleColumns";
			this.buttonVisibleColumns.Size = new System.Drawing.Size(117, 56);
			this.buttonVisibleColumns.TabIndex = 1;
			this.buttonVisibleColumns.Text = "Ορατές στήλες";
			this.buttonVisibleColumns.UseVisualStyleBackColor = true;
			this.buttonVisibleColumns.Click += new System.EventHandler(this.ButtonVisibleColumnsClick);
			// 
			// buttonAddNew
			// 
			this.buttonAddNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonAddNew.Location = new System.Drawing.Point(160, 298);
			this.buttonAddNew.Name = "buttonAddNew";
			this.buttonAddNew.Size = new System.Drawing.Size(99, 56);
			this.buttonAddNew.TabIndex = 2;
			this.buttonAddNew.Text = "Πρόσθεση";
			this.buttonAddNew.UseVisualStyleBackColor = true;
			this.buttonAddNew.Click += new System.EventHandler(this.ButtonAddNewClick);
			// 
			// buttonDelete
			// 
			this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonDelete.Location = new System.Drawing.Point(307, 299);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size(102, 55);
			this.buttonDelete.TabIndex = 3;
			this.buttonDelete.Text = "Διαγραφή";
			this.buttonDelete.UseVisualStyleBackColor = true;
			this.buttonDelete.Click += new System.EventHandler(this.ButtonDeleteClick);
			// 
			// buttonDiorthosi
			// 
			this.buttonDiorthosi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonDiorthosi.Location = new System.Drawing.Point(12, 297);
			this.buttonDiorthosi.Name = "buttonDiorthosi";
			this.buttonDiorthosi.Size = new System.Drawing.Size(100, 55);
			this.buttonDiorthosi.TabIndex = 4;
			this.buttonDiorthosi.Text = "Διόρθωση";
			this.buttonDiorthosi.UseVisualStyleBackColor = true;
			this.buttonDiorthosi.Click += new System.EventHandler(this.ButtonDiorthosiClick);
			// 
			// buttonPositions
			// 
			this.buttonPositions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonPositions.Location = new System.Drawing.Point(586, 403);
			this.buttonPositions.Name = "buttonPositions";
			this.buttonPositions.Size = new System.Drawing.Size(145, 53);
			this.buttonPositions.TabIndex = 5;
			this.buttonPositions.Text = "Διαμόρφωση Οργανωγράμματος";
			this.buttonPositions.UseVisualStyleBackColor = true;
			this.buttonPositions.Click += new System.EventHandler(this.ButtonPositionsClick);
			// 
			// buttonPositionAssignment
			// 
			this.buttonPositionAssignment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonPositionAssignment.Location = new System.Drawing.Point(12, 403);
			this.buttonPositionAssignment.Name = "buttonPositionAssignment";
			this.buttonPositionAssignment.Size = new System.Drawing.Size(100, 53);
			this.buttonPositionAssignment.TabIndex = 6;
			this.buttonPositionAssignment.Text = "Ανάθεση Καθηκόντων";
			this.buttonPositionAssignment.UseVisualStyleBackColor = true;
			this.buttonPositionAssignment.Click += new System.EventHandler(this.ButtonPositionAssignmentClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(752, 482);
			this.Controls.Add(this.buttonPositionAssignment);
			this.Controls.Add(this.buttonPositions);
			this.Controls.Add(this.buttonDiorthosi);
			this.Controls.Add(this.buttonDelete);
			this.Controls.Add(this.buttonAddNew);
			this.Controls.Add(this.buttonVisibleColumns);
			this.Controls.Add(this.personelGridView);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "MainForm";
			this.Text = "arm";
			((System.ComponentModel.ISupportInitialize)(this.personelGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button buttonPositionAssignment;
		private System.Windows.Forms.Button buttonPositions;
		private System.Windows.Forms.Button buttonDiorthosi;
		private System.Windows.Forms.BindingSource bindingSource1;
		private System.Windows.Forms.Button buttonDelete;
		private System.Windows.Forms.Button buttonAddNew;
		private System.Windows.Forms.Button buttonVisibleColumns;
		private System.Windows.Forms.DataGridView personelGridView;
	}
}
