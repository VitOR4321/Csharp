using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics; 

namespace pierwsze_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch watch;
            watch = new Stopwatch();
            Int32 a, b, i;
            Int32 il = 0;
            Console.WriteLine("Podaj początek przedziału: ");
            a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Podaj koniec przedziału: ");
            b = Int32.Parse(Console.ReadLine());
            watch.Restart();
            for (i = a; i <= b; i++)
            {
                if (pierwsze(i) == 1)
                {
                    il++;
                };
            };
            watch.Stop();
            Console.WriteLine("Czas: {0}", watch.Elapsed);
            Console.WriteLine("Ilość liczb:{0} ", il);
            Console.ReadKey(true);
        }
        static Int32 pierwsze(Int32 a)
        {
            Int32 ile = 0,i;
            for (i = 1; i <= a;i++)
                if(a%i==0)
                {
                    ile++;
                };
            if (ile==2)
            {
                return 1;
            }
            else
            {
                return 0;
            };
        }

    }
}
