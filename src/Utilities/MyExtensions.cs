/*
 * Created by SharpDevelop.
 * User: Play
 * Date: 10/06/2013
 * Time: 14:49
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using SQLite;

namespace arm
{

	public static class MyExtensions
    {
		public static object[] ToObjectArray(this SoldierRecord rec)
        {
			return new object[] {
							rec.Id, 
							rec.Onoma, 
							rec.Epitheto, 
							rec.Asm, 
							rec.Klasi,
							rec.Seira, 
							rec.ArithmosPolitikisTaytotitas,
							rec.ImerominiaGenniseos,
							
							rec.Bathmos,
							rec.Idikotita,
							rec.EinaiEfedros,
							
							rec.DieythinsiSpitiou,
							rec.DieythinsiErgasias,
							rec.Til_oikias,
							rec.Til_kinito,
							rec.Til_ergasias,
							
							rec.SeiraEmfanisis,
							rec.Kathikonta,
							rec.Group1,
							rec.Group2,
							rec.Group3,
							rec.Group4,
							rec.Group5,
							
							rec.ArithmosOplou,
							rec.ArithmosXyfoloxis,
							rec.AllosOplismos,
							
							rec.Sxolia,
							rec.LoipaStoixia,
							rec.CreationDate,
							rec.LastUpdateDate
						};
        }
    }   
}
