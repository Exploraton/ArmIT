#region (c) 2006 Matt Valerio
// DropDownTreeView Test Application
//
// 6.21.06 Matt Valerio
// (matt.valerio@gmail.com)
//
// Filename: frmMain.cs
//
// Description: Provides a simple test case for the DropDownTreeView control.
//
// This software is free software; you can modify and/or redistribute it, provided
// that the author is credited with the work.
//
// This library is distributed in the hope that it will be useful, but WITHOUT ANY
// WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS FOR A
// PARTICULAR PURPOSE.
//
#endregion


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using DropDownTreeView;

namespace TestApp
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

            InitializeExampleComponents();
        }


        private void InitializeExampleComponents()
        {
            DropDownTreeNode tn1 = new DropDownTreeNode("Vacation 2006 (Denver)");
            tn1.ComboBox.Items.Add("Vacation 2006 (Denver)");
            tn1.ComboBox.Items.Add("Vacation 2005 (Miami)");
            tn1.ComboBox.Items.Add("Vacation 2004 (Washington DC)");
            tn1.ComboBox.Items.Add("Vacation 2003 (Houston)");
            tn1.ComboBox.SelectedIndex = 0;
            tn1.BackColor = Color.AliceBlue;
            tn1.ComboBox.BackColor = Color.AliceBlue;

            DropDownTreeNode tn2 = new DropDownTreeNode("Vacation 2005 (Miami)");
            tn2.ComboBox.Items.Add("Vacation 2006 (Denver)");
            tn2.ComboBox.Items.Add("Vacation 2005 (Miami)");
            tn2.ComboBox.Items.Add("Vacation 2004 (Washington DC)");
            tn2.ComboBox.Items.Add("Vacation 2003 (Houston)");
            tn2.ComboBox.SelectedIndex = 1;
            tn2.BackColor = Color.Plum;
            tn2.ComboBox.BackColor = Color.Plum;

            DropDownTreeNode tn3 = new DropDownTreeNode("Vacation 2006 (Washington DC)");
            tn3.ComboBox.Items.Add("Vacation 2006 (Denver)");
            tn3.ComboBox.Items.Add("Vacation 2005 (Miami)");
            tn3.ComboBox.Items.Add("Vacation 2004 (Washington DC)");
            tn3.ComboBox.Items.Add("Vacation 2003 (Houston)");
            tn3.ComboBox.SelectedIndex = 2;
            tn3.BackColor = Color.LightSalmon;
            tn3.ComboBox.BackColor = Color.LightSalmon;

            TreeNode photoNode = new TreeNode("Photo Sets To Print");
            photoNode.Nodes.Add(tn1);
            photoNode.Nodes.Add(tn2);
            photoNode.Nodes.Add(tn3);
            this.dropDownTreeView1.Nodes.Add(photoNode);


            DropDownTreeNode pickleNode = new DropDownTreeNode("No pickles");
            pickleNode.ComboBox.Items.Add("No pickles");
            pickleNode.ComboBox.Items.Add("Add pickles");
            pickleNode.ComboBox.SelectedIndex = 0;

            DropDownTreeNode lettuceNode = new DropDownTreeNode("No lettuce");
            lettuceNode.ComboBox.Items.Add("No lettuce");
            lettuceNode.ComboBox.Items.Add("Add lettuce");
            lettuceNode.ComboBox.SelectedIndex = 0;
 
            DropDownTreeNode onionNode = new DropDownTreeNode("No onions");
            onionNode.ComboBox.Items.Add("No onions");
            onionNode.ComboBox.Items.Add("Add onions");
            onionNode.ComboBox.SelectedIndex = 0;

            TreeNode condimentsNode = new TreeNode("Condiments");
            condimentsNode.Nodes.Add(pickleNode);
            condimentsNode.Nodes.Add(lettuceNode);
            condimentsNode.Nodes.Add(onionNode);


            DropDownTreeNode weightNode = new DropDownTreeNode("1/4 lb.");
            weightNode.ComboBox.Items.Add("1/4 lb.");
            weightNode.ComboBox.Items.Add("1/2 lb.");
            weightNode.ComboBox.Items.Add("3/4 lb.");
            weightNode.ComboBox.SelectedIndex = 0;

            DropDownTreeNode pattyNode = new DropDownTreeNode("All beef patty");
            pattyNode.ComboBox.Items.Add("All beef patty");
            pattyNode.ComboBox.Items.Add("All chicken patty");
            pattyNode.ComboBox.SelectedIndex = 0;

            TreeNode meatNode = new TreeNode("Meat Selection");
            meatNode.Nodes.Add(weightNode);
            meatNode.Nodes.Add(pattyNode);


            TreeNode burgerNode = new TreeNode("Hamburger Selection");
            burgerNode.Nodes.Add(condimentsNode);
            burgerNode.Nodes.Add(meatNode);
            this.dropDownTreeView1.Nodes.Add(burgerNode);


            this.dropDownTreeView1.ExpandAll();
        }
    }
}