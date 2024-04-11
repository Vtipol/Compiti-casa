using System;
using System.Diagnostics;
using System.Threading;
namespace Pmmerge
{
    public class Merge
    {
        public int[] Array;
        public void create( ref int[] arr)
        {
            var watch = Stopwatch.StartNew();
            arr = new int[3000];
            Random R = new Random();
            Console.WriteLine("inizio creazione array...");
            for (int i = 0; i<arr.Length; i++)
            {
                arr[i] = R.Next(0, 3000);
                Console.WriteLine(arr[i]);
            }
            watch.Stop();
            Console.WriteLine($"Tempo di creazione dell'array: {watch.ElapsedMilliseconds}" +
                $"ms");
            int TT = 0;
            int CC = 0;
            for (int i = 1; i< arr.Length; i++)
            {
                if (arr[i]< arr[i-1])
                {
                    TT++;
                }
                else if (arr[i] > arr[i - 1])
                {
                    CC++;
                        }
            }
            if (arr.Length < 50)
            {
                Console.WriteLine($"tra qui {TT} sono completamente disordinati" +
                    $"\ne {CC} sono poco ordinati");
            }else
            {
                Console.WriteLine("l'array è troppo grande per essere in un ordine" +
                    " ragionevole");
            }
            Console.ReadKey();
        }
        public void Insertion(int[] Inserit)
        {
            var Time = Stopwatch.StartNew();
            int n = Inserit.Length;
            for (int i = 1; i < n; i++)
            {
                int ins = Inserit[i];
                int j = i - 1;
                while (j >= 0 && Inserit[j] > ins)
                {
                    Inserit[j + 1] = Inserit[j];
                    j--;
                }
                Inserit[j + 1] = ins;
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(Inserit[i]);
            }
            Time.Stop();
            Console.WriteLine($"Tempo di ordinazione dell'array: {Time.ElapsedMilliseconds}" +
                $"ms");
        }

    }
}
