namespace vittorio 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////es1
            //Console.WriteLine("metti uno score allo studente");
            //int check = 0;
            //bool s = false;
            //do
            //{
            //    s = int.TryParse(Console.ReadLine(), out check);
            //    if (!s)
            //    {
            //        Console.WriteLine("solo numeri genio");
            //        continue;
            //    }


            //    if (check >= 90)
            //    {

            //        Console.WriteLine("Un voto eccellente");
            //        break;
            //    }
            //    else if (check >= 70 && check <= 89)
            //    {

            //        Console.WriteLine("Buon voto");
            //        break;
            //    }
            //    else if (check >= 50 && check <= 69)
            //    {

            //        Console.WriteLine("Sei arrrivato alla sufficienza");
            //        break;
            //    }
            //    else if (check <= 49)
            //    {

            //        Console.WriteLine("è insufficente mi dispiace");
            //        break;
            //    }
            //} while (!s);


            ////es2
            //Console.WriteLine("vuoi la tabellina del 7?");
            //Console.WriteLine("scrvi si o scrivi no");
            //int sette = 7;
            //bool multiplicatore = false;
            //string accept = Console.ReadLine();
            //while (accept != "si" && accept != "no")
            //{
            //    Console.WriteLine("Scrivi o si o no");
            //    accept = Console.ReadLine();

            //}
            //if (accept == "si")
            //{
            //    multiplicatore = true;
            //    do
            //    {

            //        for (int i = 0; i < 11; i++)
            //        {
            //            int mult = sette * i;
            //            Console.WriteLine($"{sette} x {i} = {mult} ");
            //            if (i >= 10)
            //            {
            //                Environment.Exit(0);
            //            }

            //        }
            //    } while (multiplicatore = true);
            //}
            //else if (accept == "no")
            //{
            //    Console.WriteLine("arrivederci");
            //    Environment.Exit(0);
            //}
            //es4
            int r = 3;
            CalcolaAreaCechio(r);

        }

        static void CalcolaAreaCechio(int r)
        {
            //r = 3;
            double A = Math.PI * (r ^ 2);
            Console.Write(A);

        }

    }

}
