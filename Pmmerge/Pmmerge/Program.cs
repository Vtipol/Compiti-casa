using System;
using System.Diagnostics;
using System.Threading;
namespace Pmmerge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Merge PM = new Merge();
            PM.create(ref PM.Array);
            PM.Insertion(PM.Array);
            Console.ReadKey();
        }
    }
}