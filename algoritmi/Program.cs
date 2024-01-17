

namespace Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph graph = new Graph(5);
            Alberobinario albero = new Alberobinario();
            albero.Inserisci(new albero(4));
            albero.Inserisci(new albero(8));
            albero.Inserisci(new albero(2));
            albero.Inserisci(new albero(6));
            albero.Inserisci(new albero(1));
            albero.Inserisci(new albero(3));
            albero.Inserisci(new albero(9));
            albero.Inserisci(new albero(7));
            albero.Inserisci(new albero(5));
            // albero.Mostra();
            //Console.WriteLine(albero.cerca(5));
            graph.aggNodo(new Alberografico(1));
            graph.aggNodo(new Alberografico(2));
            graph.aggNodo(new Alberografico(3));
            graph.aggNodo(new Alberografico(4));
            graph.aggNodo(new Alberografico(5));
            graph.aggLato(0, 1);
            graph.aggLato(1, 2);
            graph.aggLato(2, 3);
            graph.aggLato(2, 4);
            graph.aggLato(4, 0);
            graph.aggLato(4, 2);
            graph.stampa();
            Console.ReadKey();
        }
    }
}