/*
 * Created by SharpDevelop.
 * User: Play
 * Date: 16/06/2013
 * Time: 12:43
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using SQLite;
using System.Xml;

namespace arm
{
	public class PositionInfo
	{
		public PositionInfo(string name, string[] groups, int sequence, SoldierRecord assignedSoldier, XmlElement xml)
		{
			Sequence = sequence;
			Name = name;
			Groups = groups;
			AssignedSoldier = assignedSoldier;
			xmlElement = xml;
			BuildGroupPath();
		}

		public int 			Sequence;
		public string[] 	Groups;
		public string 		Name;
		public string 		GroupPath;
		public SoldierRecord AssignedSoldier;
		public XmlElement xmlElement;

		void BuildGroupPath()
		{
			GroupPath="";
			foreach(string group in Groups)
			{
				GroupPath += group + ":";
			}
		}
		
		public void CopyToSoldier(SoldierRecord soldier)
		{
			soldier.SeiraEmfanisis = Sequence;
			soldier.Kathikonta = Name;
			
			if (Groups.Length>=1)		soldier.Group1 = Groups[0];
			else soldier.Group1="";
			if (Groups.Length>=2)		soldier.Group2 = Groups[1];
			else soldier.Group2="";
			if (Groups.Length>=3)		soldier.Group3 = Groups[2];
			else soldier.Group3="";
			if (Groups.Length>=4)		soldier.Group4 = Groups[3];
			else soldier.Group4="";
			if (Groups.Length>=5)		soldier.Group5 = Groups[4];
			else soldier.Group5="";
		}
	}
}
