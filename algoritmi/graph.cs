using System;
namespace Tree
{
	public class Graph
	{
		List<Alberografico> nodi;
		int[][] Disegno;

		public Graph(int grandezza)
		{

           nodi = new List<Alberografico>();
            Disegno = new int[grandezza][];
			for (int i = 0; i< grandezza; i++)
			{
				Disegno[i] = new int[grandezza];
			}
		}
		public void aggNodo(Alberografico nodo)
		{
			nodi.Add(nodo);
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
			foreach(Alberografico n in nodi)
			{
				Console.Write(" " + n.Data );
			}
			Console.WriteLine("");
			for (int i = 0; i<Disegno.Length; i++)
			{
				Console.Write(nodi[i].Data + "");
                for (int j = 0; j < Disegno[i].Length; j++)
				{
					Console.Write( Disegno[i][j] + " ");
				}
				Console.WriteLine(" ");
            }
		}
	}
}
