using System;
namespace Tree
{
	public class Graph
	{
		int[][] Disegno;

		public Graph(int grandezza)
		{
			Disegno = new int[grandezza][];
			for (int i = 0; i< grandezza; i++)
			{
				Disegno[i] = new int[grandezza];
			}
		}
		public void aggNodo(Alberografico nodo)
		{

		}
		public void aggLato(int ris, int dest)
		{
			Disegno[ris][dest] = 1;
		}
		public bool Lato(int ris, int dest)
		{
			if(Disegno[ris][dest] == 1)
			{
				return true;
			}
			return false;
		}
		public void stampa()
		{
			for (int i = 0; i<Disegno.Length; i++)
			{
                for (int j = 0; j < Disegno[i].Length; j++)
				{
					Console.Write(Disegno[i][j] + "");
				}
				Console.WriteLine("");
            }
		}
	}
}

