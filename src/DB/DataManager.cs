/*
 * Created by SharpDevelop.
 * User: sotos
 * Date: 09/05/2013
 * Time: 17:55
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;
using System.Windows.Forms;
using SQLite;
using System.Collections.Generic;
using System.Linq;

namespace arm
{
	public class DataManager
	{
		public string databaseFilePath;
		private SQLite.SQLiteConnection dbConnection;
		
		static private DataManager singleton;
		static public DataManager Singleton 
		{ 
			get 
			{
				if (singleton==null) 
					singleton = new DataManager();
				return singleton;
			}
			set { singleton = value; } 
		}

		public DataManager()
		{
			databaseFilePath  = Path.Combine(System.Windows.Forms.Application.StartupPath,  "personel.sqlite");
		}
		
		public void Initialize()
		{
			if (!File.Exists(databaseFilePath))
			{
				dbConnection = new SQLite.SQLiteConnection(databaseFilePath);
				dbConnection.CreateTable<PropertyRecord>();
				dbConnection.CreateTable<SoldierRecord>();
			}
			else
			{
				dbConnection = new SQLiteConnection(databaseFilePath);
			}
		}
	
		public List<SoldierRecord> ReadSoldiers()
		{
			List<SoldierRecord> records;
			try 
			{
				
				records = dbConnection.Query<SoldierRecord>("select * from SoldierRecord");
			}
			catch(Exception xcp) 
			{
				return new List<SoldierRecord>();
			}
			return records;
		}
				
		public string[] GetSoldierRecordColumnNames()
		{
			List<SQLiteConnection.ColumnInfo> columns = dbConnection.GetTableInfo( "SoldierRecord" );
			
			return Array.ConvertAll(columns.ToArray(), item => item.Name );
		}
		
		public void Insert(SoldierRecord soldier)
		{
			dbConnection.Insert(soldier, typeof(SoldierRecord));
		}
		
		public void Update(SoldierRecord soldier)
		{
			dbConnection.Update(soldier, typeof(SoldierRecord));
		}

		public bool Delete(SoldierRecord soldier)
		{
			if (soldier.Id>0)
			{
				return dbConnection.Delete<SoldierRecord>(soldier.Id)==1;
			}
			return false;
		}
		
		// DB properties access methods
		public bool SetProperty(string propertyName, string propertyValue)
		{
			List<PropertyRecord> records;
			try 
			{
				records = dbConnection.Query<PropertyRecord>("select Name from PropertyRecord where Name=?"
				                                            , propertyName);
				if (records.Count==1)
				{
					records[0].Value = propertyValue;
					dbConnection.Update(records[0]);
				}
				else
					dbConnection.Insert( new PropertyRecord { Name = propertyName, Value = propertyValue } );
			}
			catch(Exception xcp) 
			{
				return false;
			}
			return true;
		}
		
		public string GetProperty(string propertyName)
		{
			List<PropertyRecord> records;
			try 
			{
				records = dbConnection.Query<PropertyRecord>("select Value from PropertyRecord where Name=?"
				                                            , propertyName);
				if (records.Count==1)
					return records[0].Value;
			}
			catch(Exception xcp) 
			{
				return null;
			}
			return null;
		}
		
		public bool UpdateSoldierPosition(int soldierId, PositionInfo pos)
		{
			try
			{
				string[] groups = new string[5] { "","","","","" };
				pos.Groups.CopyTo(groups,0);
				
				dbConnection.Execute("Update SoldierRecord Set SeiraEmfanisis=?, kathikonta=?, " +
				                     "Group1=?, Group2=?, Group3=?, Group4=?, Group5=? Where Id=?"
				                     , pos.Sequence
				                     , pos.Name
				                     , groups[0]
				                     , groups[1]
				                     , groups[2]
				                     , groups[3]
				                     , groups[4]
				                     , soldierId);
				return true;
			}
			catch(Exception xcp)
			{
				string msg = xcp.ToString();
			};
			return false;
		}
		
		public void BeginTransaction()
		{
			dbConnection.BeginTransaction();
		}
		
		public void CommitTransaction()
		{
			dbConnection.Commit();
		}
	}
}
