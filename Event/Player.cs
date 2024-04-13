using System;
namespace Event
{
	public class Player
	{
        public void HandleEvent(string message, EventDelegate eventHandler)
        {
            Console.WriteLine("Evento: " + message);
            eventHandler?.Invoke("Messaggio aggiuntivo");
        }
    }
}

