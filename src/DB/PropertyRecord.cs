/*
 * Created by SharpDevelop.
 * User: Play
 * Date: 11/06/2013
 * Time: 12:40
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using SQLite;

namespace SQLite
{
	public class PropertyRecord
	{
		public PropertyRecord()
		{
		}

		[PrimaryKey]
		public string 	Name { get; set; }
		public string 	Value { get; set; }
	}
}
