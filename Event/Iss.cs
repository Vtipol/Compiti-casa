using System;
namespace Event
{
	public class Iss
	{
        public void HandleEvent(string message)
        {
            Console.WriteLine("Evento: " + message);
        }

    }
}

