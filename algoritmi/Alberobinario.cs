using System;
namespace Tree
{
	public class Alberobinario
	{
		
			albero tronco;
			public void Inserisci(albero nodo)
			{
			tronco = inseriscialbero(tronco, nodo);
			}
       private albero inseriscialbero(albero tronco, albero nodo)
        {
			int data = nodo.Data;
			if (tronco == null)
			{
				tronco = nodo;
				return tronco;
			}
			else if (data < tronco.Data)
			{ tronco.sinistra = inseriscialbero(tronco.sinistra, nodo); }
			else
			{ tronco.destra = inseriscialbero(tronco.destra, nodo); }
			return tronco;
        }
        public void Mostra()
		{
			demostrazione(tronco);
		}
		private void demostrazione(albero tronco)
			{
			if (tronco != null)
			{
				demostrazione(tronco.sinistra);
				Console.WriteLine(tronco.Data);
				demostrazione(tronco.destra);
			}
		}
		public bool cerca(int data)
		{
			return cercatore(tronco, data);
		
		}
		private bool cercatore(albero tronco, int data)
		{
			if (tronco == null)
			{
				return false;
			}
			else if (tronco.Data == data)
			{
				return true;
			}
			else if (tronco.Data > data)
			{
				return cercatore(tronco.sinistra, data);
			}
			else { return cercatore(tronco.sinistra, data); }

           
		}
		public void remove(int data)
		{

		}
		public albero rimozione(albero tronco, int data)
		{
			return null;
		}
		private int successore(albero tronco)
		{
			return 1;
		}
        private int predecessore(albero tronco)
        {
			return 1;
        }
    }
}

