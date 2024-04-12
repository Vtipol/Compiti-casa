using System;

namespace NPi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Notation notate = new Notation();
            ARR Note = new ARR();
            Stack<int> stack = new Stack<int>();
            List<int> list = new List<int>();
            Note.note(ref stack);
            //notate.Notate(ref stack);
            Console.ReadKey();
        }
    }
}