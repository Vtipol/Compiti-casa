using System;
namespace Tree
{
	public class albero
	{
      public int Data { get; set; }
		public albero sinistra;
		public albero destra;
		public albero(int data)
		{
			Data = data;
		}
	}
}

