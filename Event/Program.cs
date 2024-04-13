using System;
using Event;
namespace Event
{
    internal class Program
    {
        static void Stampa(string message)
        {
            Console.WriteLine("Messaggio aggiuntivo: " + message);
        }
        static void Main(string[] args)
        {
            Evento evento = new Evento();
            EventDelegate handler = new EventDelegate(Stampa);
            Player P1 = new Player();
            Player P2 = new Player();
            Iss iss = new Iss();
            /*
            evento.MyEvent += P1.HandleEvent;
            evento.MyEvent += P2.HandleEvent;
            evento.MyEvent += iss.HandleEvent;
            evento.RaiseEvent("messaggio");
            evento.MyEvent -= P1.HandleEvent;
            evento.MyEvent -= P2.HandleEvent;
            evento.RaiseEvent("Riferimento");
            */
            P1.HandleEvent("evento", handler);
            Console.ReadKey();
        }
    }
}