using System;
using System.Diagnostics;



namespace LiczbyAlgorytm
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Stopwatch sw = new Stopwatch();
            int[] tablica = new int[100000001];
            
            for (int ctr = 1; ctr <= 100000000; ctr++)
            {
                tablica[ctr] = rnd.Next(50000000);
            }


            /*
            for (int ctr = 0; ctr < tablica.Length; ctr++)
            {
                Console.WriteLine($"tablica[{ctr}] = {tablica[ctr]}");
            }*/
            
           
            sw.Start();
            int wynik;
            wynik = tablica[0];
            for (int ctr=1; ctr<tablica.Length; ctr++)
            {
                if (wynik < tablica[ctr])
                {
                    wynik = tablica[ctr];
                }
            }
            // najwekszy element
            Console.WriteLine("Najwiekszy element to: " + wynik);
            sw.Stop();
            Console.WriteLine("czas wykonania:");
            Console.WriteLine(sw.ElapsedMilliseconds);


        }
    }
}
