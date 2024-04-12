using System;
using System.Collections.Generic;
namespace CNT
{
	public class BIT
	{
		public Dictionary<string, float> dict = new Dictionary<string, float>();


		public void ex(ref Dictionary<string, float> d)
		{
            d.Add("2024-01-22", 242);
            d.Add("2024-01-23", 247);
            d.Add("2024-01-28", 251);
			d.Add("2024-01-11", 123);
            d.Add("2024-02-02", 288);
            d.Add("2024-02-03", 399);
            d.Add("2024-02-04", 403);
			d.Add("2001-12-01", 345);
            d.Add("2024-02-05", 321);
            d.Add("2024-02-10", 123);

		}
		public void CheckK( ref Dictionary<string, float> Dic)
		{
			string[] Keys = Dic.Keys.ToArray();
			int CorrectL;
			int Dnn = 0;
			for (int i = 0; i< Keys.Length; i++)
			{
				DateTime date = DateTime.Parse(Keys[i]);
				int year = date.Year;
				int month = date.Month;
				int day = date.Day;
				CorrectL = Keys[i].Length;
				if(CorrectL != 10)
				{
					Dnn++;
					Dic.Remove(Dic.ElementAt(i).Key);
					continue;
				}
				if (year != 2024)
				{
                    Dnn++;
                    Dic.Remove(Dic.ElementAt(i).Key);
					continue;
                }
			}
            Console.WriteLine($"date invalide : {Dnn}");
        }
		public void Show(Dictionary<string,float> D)
		{
			foreach(KeyValuePair<string, float> kvp in D)
			{
			Console.WriteLine("Date : {0} Value : {1} ", kvp.Key, kvp.Value);
			}
		}
	}
}

