/*
 * Created by SharpDevelop.
 * User: Play
 * Date: 13/06/2013
 * Time: 13:46
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace arm
{
	partial class PositionsForm
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
			System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Κορυφή");
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PositionsForm));
			this.label1 = new System.Windows.Forms.Label();
			this.PositionsTreeView = new System.Windows.Forms.TreeView();
			this.buttonSaveHierarchy = new System.Windows.Forms.Button();
			this.buttonLoadHierarchy = new System.Windows.Forms.Button();
			this.buttonSave = new System.Windows.Forms.Button();
			this.buttonAddNode = new System.Windows.Forms.Button();
			this.buttonRemoveNode = new System.Windows.Forms.Button();
			this.buttonDuplicate = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonUp = new System.Windows.Forms.Button();
			this.buttonDown = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(66, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(265, 24);
			this.label1.TabIndex = 2;
			this.label1.Text = "Οργανώγραμα";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// PositionsTreeView
			// 
			this.PositionsTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.PositionsTreeView.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PositionsTreeView.FullRowSelect = true;
			this.PositionsTreeView.HideSelection = false;
			this.PositionsTreeView.LabelEdit = true;
			this.PositionsTreeView.Location = new System.Drawing.Point(66, 40);
			this.PositionsTreeView.Name = "PositionsTreeView";
			treeNode4.Name = "Node0";
			treeNode4.Text = "Κορυφή";
			this.PositionsTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
									treeNode4});
			this.PositionsTreeView.Size = new System.Drawing.Size(305, 398);
			this.PositionsTreeView.TabIndex = 3;
			// 
			// buttonSaveHierarchy
			// 
			this.buttonSaveHierarchy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonSaveHierarchy.Location = new System.Drawing.Point(13, 444);
			this.buttonSaveHierarchy.Name = "buttonSaveHierarchy";
			this.buttonSaveHierarchy.Size = new System.Drawing.Size(140, 39);
			this.buttonSaveHierarchy.TabIndex = 5;
			this.buttonSaveHierarchy.Text = "Εξαγωγή Ιεραρχίας\r\nΣε Αρχείο";
			this.buttonSaveHierarchy.UseVisualStyleBackColor = true;
			this.buttonSaveHierarchy.Click += new System.EventHandler(this.ButtonSaveHierarchyClick);
			// 
			// buttonLoadHierarchy
			// 
			this.buttonLoadHierarchy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonLoadHierarchy.Location = new System.Drawing.Point(14, 489);
			this.buttonLoadHierarchy.Name = "buttonLoadHierarchy";
			this.buttonLoadHierarchy.Size = new System.Drawing.Size(139, 39);
			this.buttonLoadHierarchy.TabIndex = 6;
			this.buttonLoadHierarchy.Text = "Εισαγωγή Ιεραρχείας\r\n Από Αρχείο";
			this.buttonLoadHierarchy.UseVisualStyleBackColor = true;
			this.buttonLoadHierarchy.Click += new System.EventHandler(this.ButtonLoadHierarchyClick);
			// 
			// buttonSave
			// 
			this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonSave.Location = new System.Drawing.Point(323, 447);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(109, 36);
			this.buttonSave.TabIndex = 7;
			this.buttonSave.Text = "Επιβεβαίωση";
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Click += new System.EventHandler(this.ButtonSaveClick);
			// 
			// buttonAddNode
			// 
			this.buttonAddNode.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonAddNode.BackgroundImage")));
			this.buttonAddNode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.buttonAddNode.Location = new System.Drawing.Point(13, 109);
			this.buttonAddNode.Name = "buttonAddNode";
			this.buttonAddNode.Size = new System.Drawing.Size(44, 44);
			this.buttonAddNode.TabIndex = 8;
			this.buttonAddNode.UseVisualStyleBackColor = true;
			this.buttonAddNode.Click += new System.EventHandler(this.ButtonAddNodeClick);
			// 
			// buttonRemoveNode
			// 
			this.buttonRemoveNode.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonRemoveNode.BackgroundImage")));
			this.buttonRemoveNode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.buttonRemoveNode.Location = new System.Drawing.Point(13, 299);
			this.buttonRemoveNode.Name = "buttonRemoveNode";
			this.buttonRemoveNode.Size = new System.Drawing.Size(45, 44);
			this.buttonRemoveNode.TabIndex = 9;
			this.buttonRemoveNode.UseVisualStyleBackColor = true;
			this.buttonRemoveNode.Click += new System.EventHandler(this.ButtonRemoveNodeClick);
			// 
			// buttonDuplicate
			// 
			this.buttonDuplicate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonDuplicate.BackgroundImage")));
			this.buttonDuplicate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.buttonDuplicate.Location = new System.Drawing.Point(13, 196);
			this.buttonDuplicate.Name = "buttonDuplicate";
			this.buttonDuplicate.Size = new System.Drawing.Size(44, 44);
			this.buttonDuplicate.TabIndex = 10;
			this.buttonDuplicate.UseVisualStyleBackColor = true;
			this.buttonDuplicate.Click += new System.EventHandler(this.ButtonDuplicateClick);
			// 
			// buttonCancel
			// 
			this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonCancel.Location = new System.Drawing.Point(323, 491);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(110, 35);
			this.buttonCancel.TabIndex = 11;
			this.buttonCancel.Text = "Ακύρωση Αλλαγών";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.ButtonCancelClick);
			// 
			// buttonUp
			// 
			this.buttonUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonUp.BackgroundImage")));
			this.buttonUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.buttonUp.Location = new System.Drawing.Point(387, 156);
			this.buttonUp.Name = "buttonUp";
			this.buttonUp.Size = new System.Drawing.Size(46, 44);
			this.buttonUp.TabIndex = 12;
			this.buttonUp.UseVisualStyleBackColor = true;
			this.buttonUp.Click += new System.EventHandler(this.ButtonUpClick);
			// 
			// buttonDown
			// 
			this.buttonDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonDown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonDown.BackgroundImage")));
			this.buttonDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.buttonDown.Location = new System.Drawing.Point(387, 261);
			this.buttonDown.Name = "buttonDown";
			this.buttonDown.Size = new System.Drawing.Size(46, 44);
			this.buttonDown.TabIndex = 13;
			this.buttonDown.UseVisualStyleBackColor = true;
			this.buttonDown.Click += new System.EventHandler(this.ButtonDownClick);
			// 
			// PositionsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(448, 536);
			this.Controls.Add(this.buttonDown);
			this.Controls.Add(this.buttonUp);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonDuplicate);
			this.Controls.Add(this.buttonRemoveNode);
			this.Controls.Add(this.buttonAddNode);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.buttonLoadHierarchy);
			this.Controls.Add(this.buttonSaveHierarchy);
			this.Controls.Add(this.PositionsTreeView);
			this.Controls.Add(this.label1);
			this.MinimumSize = new System.Drawing.Size(400, 500);
			this.Name = "PositionsForm";
			this.Text = "PositionsForm";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button buttonDown;
		private System.Windows.Forms.Button buttonUp;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Button buttonDuplicate;
		private System.Windows.Forms.Button buttonRemoveNode;
		private System.Windows.Forms.Button buttonAddNode;
		private System.Windows.Forms.Button buttonSave;
		private System.Windows.Forms.Button buttonLoadHierarchy;
		private System.Windows.Forms.Button buttonSaveHierarchy;
		private System.Windows.Forms.TreeView PositionsTreeView;
		private System.Windows.Forms.Label label1;
	}
}
