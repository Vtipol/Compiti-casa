using System;

namespace CNT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BIT bit = new BIT();
            Dictionary<string, float> dict = new Dictionary<string, float>();
            bit.ex(ref dict);
            bit.CheckK(ref dict);
            bit.Show(dict);

            Console.ReadKey();
        }
    }
}