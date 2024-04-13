using System;
namespace Event
{
    public delegate void EventHandler(string message);
    public delegate void EventDelegate(string message);

    public class Evento
    {
        public event EventHandler MyEvent;
        public void RaiseEvent(string message)
        {
            Console.WriteLine("Evento generato: " + message);
            MyEvent?.Invoke(message);
        }
    }

}