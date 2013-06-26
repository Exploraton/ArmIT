/*
 * Created by SharpDevelop.
 * User: Play
 * Date: 15/06/2013
 * Time: 14:27
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace arm
{
	/// <summary>
	/// Description of TreeViewItemXmlSerializer.
	/// </summary>
	public static class TreeViewItemXmlSerializer
	{
		// build Xml from Tree items
		public static string XmlFromTree(TreeNode head)
		{
			XmlDocument xmlDoc = new XmlDocument();
			XmlElement xmlRoot = xmlDoc.CreateElement("root");
			xmlRoot.SetAttribute("t", head.Text);
			xmlDoc.AppendChild(xmlRoot);

			BuildXMLFromTree( head, xmlRoot, xmlDoc);
			
			StringWriter textWriter = new StringWriter();
			xmlDoc.Save(textWriter);
			textWriter.Close();
			return textWriter.ToString();
		}
		
		static void BuildXMLFromTree(TreeNode head, XmlElement xmlHead, XmlDocument xmlDoc)
		{
			foreach(TreeNode child in head.Nodes)
			{
				XmlElement xmlChild = xmlDoc.CreateElement("n");
				xmlChild.SetAttribute("t", child.Text);
				if (child.Tag!=null)
					xmlChild.SetAttribute("soldierId", child.Tag.ToString());
				xmlHead.AppendChild(xmlChild);

				BuildXMLFromTree(child, xmlChild, xmlDoc);
			}
		}

		// Build Tree from Xml ---------
		
		public static TreeNode BuildTreeFromXML(string xml)
		{
			XmlDocument xmlDoc = new XmlDocument();
			XmlElement xmlRoot=null;
			xmlDoc.LoadXml( xml);
			xmlRoot = (XmlElement) xmlDoc.GetElementsByTagName("root").Item(0);

			if (xmlRoot== null)
	       		return null;
			
            string headText = xmlRoot.GetAttribute("t");
            if (headText==string.Empty)	
            	headText = "Άδειο";
            TreeNode top = new TreeNode( headText );
			
			BuildTreeFromXML(top, xmlRoot);
			top.ExpandAll();
			return top;
		}

		static void BuildTreeFromXML(TreeNode head, XmlElement xmlHead)
		{
			foreach(XmlElement xmlChild in xmlHead.ChildNodes)
			{
				TreeNode child = head.Nodes.Add( xmlChild.GetAttribute("t"));
				child.Tag = xmlChild.GetAttribute("soldierId");
				BuildTreeFromXML(child, xmlChild);
			}
		}
		
	}
}
