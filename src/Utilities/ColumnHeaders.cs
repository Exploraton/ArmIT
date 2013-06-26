/*
 * Created by SharpDevelop.
 * User: Play
 * Date: 10/05/2013
 * Time: 22:48
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace arm
{
	/// <summary>
	/// Description of ColumnHeaders.
	/// </summary>
	public class ColumnHeaders
	{
		public string headersFilePath;
		public Dictionary<string, string> headers;

		public ColumnHeaders()
		{
			headers = new Dictionary<string, string>();
			headersFilePath =  Path.Combine(System.Windows.Forms.Application.StartupPath,  "headers.txt");
		}
		
		public void Read()
		{
			try
	        {
	            using (StreamReader sr = new StreamReader(headersFilePath))
	            {
	            	while(!sr.EndOfStream)
	            	{
		            	String line = sr.ReadLine();
		            	string[] tokens = line.Split(',');
		            	headers.Add(tokens[0], tokens[1]);
	            	}
	            }
	        }
	        catch (Exception e)
	        {
	            Console.WriteLine("The file could not be read:");
	            Console.WriteLine(e.Message);
	        }
		}
		
		public string[] ColumnNames
		{
			get { return headers.Keys.ToArray(); }
		}
		public string[] ColumnTranslations
		{
			get { return headers.Values.ToArray(); }
		}
		
		public string Get(string key)
		{
			string headerText;
			if (!headers.TryGetValue(key, out headerText))
				return string.Empty;
			return headerText;
		}
		
		public string[] ValuesToArray()
		{
			List<string> list = new List<string>();
    		list.AddRange(headers.Values);
    		return list.ToArray();
		}
	}
}
