using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics; 

namespace sito
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch watch;
            watch = new Stopwatch();
            int i, j, a, d,il=0;
            Console.WriteLine("zakres od 1 do a(liczba podana przez użytownika): ");
            Console.Write("Podaj górny zakres: ");
            a = int.Parse(Console.ReadLine());
            watch.Restart();
            int[] tab = new int[1000000];
            d = (int)Math.Floor(Math.Sqrt(a));         
            for (i = 1; i <= a; i++) 
                tab[i] = i;        
            for (i = 2; i <= d; i++)
            {
                if (tab[i] != 0)
                {
                    j = i + i;
                    while (j <= a)
                    {
                        tab[j] = 0;
                        j += i;
                    };
                };
            };       
            for (i = 2; i <= a; i++)
            {
                if (tab[i] != 0)
                {
                    il++;
                };
            };
            watch.Stop();
            Console.WriteLine("Czas: {0}", watch.Elapsed);
            Console.WriteLine("Ilość liczb:{0} ", il);
            Console.ReadKey(true);
        }
    }
}