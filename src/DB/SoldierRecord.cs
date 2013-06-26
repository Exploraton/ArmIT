/*
 * Created by SharpDevelop.
 * User: sotos
 * Date: 09/05/2013
 * Time: 17:28
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data.SQLite;
using SQLite;

namespace SQLite
{
	public class SoldierRecord
	{
		public SoldierRecord()
		{}
		
		
		public SoldierRecord(SoldierRecord other)
		{
			CopyFrom(other);
		}
		
		public void CopyFrom(SoldierRecord other)
		{
			Id = other.Id;
			Onoma = other.Onoma;
			Epitheto = other.Epitheto;
			Asm = other.Asm;
			Klasi = other.Klasi;
			Seira = other.Seira;
			ArithmosPolitikisTaytotitas = other.ArithmosPolitikisTaytotitas;
			ImerominiaGenniseos = other.ImerominiaGenniseos;
			
			Bathmos = other.Bathmos;
			Idikotita = other.Idikotita;
			EinaiEfedros = other.EinaiEfedros;
		
			DieythinsiSpitiou = other.DieythinsiSpitiou;
			DieythinsiErgasias = other.DieythinsiErgasias;
			Til_oikias	= other.Til_oikias;
			Til_kinito	= other.Til_kinito;
			Til_ergasias = other.Til_ergasias;
			
			SeiraEmfanisis = other.SeiraEmfanisis;
			Kathikonta = other.Kathikonta;
			Group1 = other.Group1;
			Group2 = other.Group2;
			Group3 = other.Group3;
			Group4 = other.Group4;
			Group5 = other.Group5;
		
			ArithmosOplou = other.ArithmosOplou;
			ArithmosXyfoloxis = other.ArithmosXyfoloxis;
			AllosOplismos = other.AllosOplismos;
			
			Sxolia = other.Sxolia;
			LoipaStoixia = other.LoipaStoixia;
			CreationDate = other.CreationDate;
			LastUpdateDate = other.LastUpdateDate;
		}
		
		[PrimaryKey, AutoIncrement]
		public int Id { get; set; }
		
		public string 	Onoma { get; set; }
		public string 	Epitheto { get; set; }
		public int 		Asm { get; set; }
		public int 		Klasi { get; set; }
		public string 	Seira { get; set; }
		public int 		ArithmosPolitikisTaytotitas { get; set; }
		public DateTime ImerominiaGenniseos { get; set; }

		public string 	Bathmos { get; set; }
		public string 	Idikotita { get; set; }
		public string  	EinaiEfedros { get; set; }
		
		public string 	DieythinsiSpitiou { get; set; }
		public string 	DieythinsiErgasias { get; set; }
		public string 	Til_oikias { get; set; }
		public string 	Til_kinito { get; set; }
		public string 	Til_ergasias { get; set; }
		
		public int 		SeiraEmfanisis { get; set; }
		public string 	Kathikonta { get; set; }
		public string 	Group1 { get; set; }
		public string 	Group2 { get; set; }
		public string 	Group3 { get; set; }
		public string 	Group4 { get; set; }
		public string 	Group5 { get; set; }	
		
		public string ArithmosOplou { get; set; }
		public string ArithmosXyfoloxis { get; set; }
		public string AllosOplismos { get; set; }
		
		public string 	Sxolia  { get; set; }
		public string 	LoipaStoixia  { get; set; }
		public DateTime CreationDate { get; set; }
		public DateTime LastUpdateDate { get; set; }
		
		
		public override string ToString()
		{
			return string.Format("{0} {1} - {2} - {3} {4} ({5}/{6})", EinaiEfedros, Bathmos, Idikotita, Epitheto, Onoma, Asm, Klasi);
		}
	}
}
