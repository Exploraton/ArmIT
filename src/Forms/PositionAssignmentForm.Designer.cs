/*
 * Created by SharpDevelop.
 * User: Play
 * Date: 16/06/2013
 * Time: 01:19
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace arm
{
	partial class PositionAssignmentForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PositionAssignmentForm));
			this.PositionsListView = new System.Windows.Forms.ListView();
			this.positionColumnHeader = new System.Windows.Forms.ColumnHeader();
			this.personColumnHeader = new System.Windows.Forms.ColumnHeader();
			this.AssignmentIconsImageList = new System.Windows.Forms.ImageList(this.components);
			this.buttonDone = new System.Windows.Forms.Button();
			this.labelUnassignedSoldiers = new System.Windows.Forms.Label();
			this.UnassignedListBox = new System.Windows.Forms.ListBox();
			this.buttonAssign = new System.Windows.Forms.Button();
			this.buttonClearPosition = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.progressBar = new System.Windows.Forms.ProgressBar();
			this.SuspendLayout();
			// 
			// PositionsListView
			// 
			this.PositionsListView.AutoArrange = false;
			this.PositionsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.positionColumnHeader,
									this.personColumnHeader});
			this.PositionsListView.Dock = System.Windows.Forms.DockStyle.Top;
			this.PositionsListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PositionsListView.FullRowSelect = true;
			this.PositionsListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.PositionsListView.HideSelection = false;
			this.PositionsListView.Location = new System.Drawing.Point(0, 0);
			this.PositionsListView.MultiSelect = false;
			this.PositionsListView.Name = "PositionsListView";
			this.PositionsListView.Size = new System.Drawing.Size(650, 252);
			this.PositionsListView.SmallImageList = this.AssignmentIconsImageList;
			this.PositionsListView.TabIndex = 0;
			this.PositionsListView.UseCompatibleStateImageBehavior = false;
			this.PositionsListView.View = System.Windows.Forms.View.Details;
			// 
			// positionColumnHeader
			// 
			this.positionColumnHeader.Text = "Θέση";
			this.positionColumnHeader.Width = 223;
			// 
			// personColumnHeader
			// 
			this.personColumnHeader.Text = "Ατομο";
			this.personColumnHeader.Width = 401;
			// 
			// AssignmentIconsImageList
			// 
			this.AssignmentIconsImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("AssignmentIconsImageList.ImageStream")));
			this.AssignmentIconsImageList.TransparentColor = System.Drawing.Color.White;
			this.AssignmentIconsImageList.Images.SetKeyName(0, "exclamationIcon.bmp");
			this.AssignmentIconsImageList.Images.SetKeyName(1, "checkIcon.bmp");
			// 
			// buttonDone
			// 
			this.buttonDone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonDone.Location = new System.Drawing.Point(13, 505);
			this.buttonDone.Name = "buttonDone";
			this.buttonDone.Size = new System.Drawing.Size(105, 42);
			this.buttonDone.TabIndex = 1;
			this.buttonDone.Text = "Επιβεβαίωση Αλλαγών";
			this.buttonDone.UseVisualStyleBackColor = true;
			this.buttonDone.Click += new System.EventHandler(this.ButtonDoneClick);
			// 
			// labelUnassignedSoldiers
			// 
			this.labelUnassignedSoldiers.Location = new System.Drawing.Point(178, 281);
			this.labelUnassignedSoldiers.Name = "labelUnassignedSoldiers";
			this.labelUnassignedSoldiers.Size = new System.Drawing.Size(139, 33);
			this.labelUnassignedSoldiers.TabIndex = 2;
			this.labelUnassignedSoldiers.Text = "Διαθέσιμο Προσωπικό";
			this.labelUnassignedSoldiers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// UnassignedListBox
			// 
			this.UnassignedListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.UnassignedListBox.DisplayMember = "DisplayText";
			this.UnassignedListBox.FormattingEnabled = true;
			this.UnassignedListBox.Location = new System.Drawing.Point(169, 320);
			this.UnassignedListBox.Name = "UnassignedListBox";
			this.UnassignedListBox.Size = new System.Drawing.Size(469, 251);
			this.UnassignedListBox.TabIndex = 3;
			// 
			// buttonAssign
			// 
			this.buttonAssign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.buttonAssign.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.buttonAssign.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonAssign.Image = ((System.Drawing.Image)(resources.GetObject("buttonAssign.Image")));
			this.buttonAssign.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonAssign.Location = new System.Drawing.Point(455, 258);
			this.buttonAssign.Name = "buttonAssign";
			this.buttonAssign.Size = new System.Drawing.Size(183, 56);
			this.buttonAssign.TabIndex = 4;
			this.buttonAssign.Text = "Πλήρωση\r\nΘέσης";
			this.buttonAssign.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonAssign.UseVisualStyleBackColor = false;
			this.buttonAssign.Click += new System.EventHandler(this.ButtonAssignClick);
			// 
			// buttonClearPosition
			// 
			this.buttonClearPosition.BackColor = System.Drawing.Color.LightCoral;
			this.buttonClearPosition.Location = new System.Drawing.Point(12, 259);
			this.buttonClearPosition.Name = "buttonClearPosition";
			this.buttonClearPosition.Size = new System.Drawing.Size(88, 56);
			this.buttonClearPosition.TabIndex = 5;
			this.buttonClearPosition.Text = "Κένωση\r\nΘέσης";
			this.buttonClearPosition.UseVisualStyleBackColor = false;
			this.buttonClearPosition.Click += new System.EventHandler(this.ButtonClearPositionClick);
			// 
			// buttonCancel
			// 
			this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonCancel.Location = new System.Drawing.Point(13, 420);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(104, 42);
			this.buttonCancel.TabIndex = 6;
			this.buttonCancel.Text = "Ακύρωση Αλλαγών";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.ButtonCancelClick);
			// 
			// progressBar
			// 
			this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.progressBar.Location = new System.Drawing.Point(13, 551);
			this.progressBar.Name = "progressBar";
			this.progressBar.Size = new System.Drawing.Size(105, 16);
			this.progressBar.TabIndex = 7;
			// 
			// PositionAssignmentForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.ClientSize = new System.Drawing.Size(650, 579);
			this.ControlBox = false;
			this.Controls.Add(this.progressBar);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonClearPosition);
			this.Controls.Add(this.buttonAssign);
			this.Controls.Add(this.UnassignedListBox);
			this.Controls.Add(this.labelUnassignedSoldiers);
			this.Controls.Add(this.buttonDone);
			this.Controls.Add(this.PositionsListView);
			this.Name = "PositionAssignmentForm";
			this.Text = "Ανάθεση Καθηκόντων";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.ProgressBar progressBar;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Button buttonClearPosition;
		private System.Windows.Forms.Button buttonAssign;
		private System.Windows.Forms.ListBox UnassignedListBox;
		private System.Windows.Forms.Label labelUnassignedSoldiers;
		private System.Windows.Forms.ImageList AssignmentIconsImageList;
		private System.Windows.Forms.Button buttonDone;
		private System.Windows.Forms.ColumnHeader personColumnHeader;
		private System.Windows.Forms.ColumnHeader positionColumnHeader;
		private System.Windows.Forms.ListView PositionsListView;
	}
}
