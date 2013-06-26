/*
 * Created by SharpDevelop.
 * User: Play
 * Date: 10/05/2013
 * Time: 19:58
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace arm
{
	/// <summary>
	/// Description of Class1.
	/// </summary>
	public class FieldFixtures
	{
		public string fixturesFilePath;
		public Dictionary<string, string[]> fixtures;
		
		public FieldFixtures()
		{
			fixtures = new Dictionary<string, string[]>();
			fixturesFilePath =  Path.Combine(System.Windows.Forms.Application.StartupPath,  "fixtures.txt");
		}
		
		public void Read()
		{
			try
	        {
	            using (StreamReader sr = new StreamReader(fixturesFilePath))
	            {
	            	while(!sr.EndOfStream)
	            	{
		            	String line = sr.ReadLine();
		            	string[] tokens = line.Split(',');
		            	string[] options = new string[tokens.Length-1];
		            	Array.Copy(tokens,1, options, 0, tokens.Length-1);
		            	fixtures.Add(tokens[0], options);
	            	}
	            }
	        }
	        catch (Exception e)
	        {
	            Console.WriteLine("the Fixtures file could not be read:");
	            Console.WriteLine(e.Message);
	        }		
		}
		
		public string[] Get(string fixtureName)
		{
			string[] fixtureList;
			fixtures.TryGetValue(fixtureName, out fixtureList);
			return fixtureList;
		}
	}
}
