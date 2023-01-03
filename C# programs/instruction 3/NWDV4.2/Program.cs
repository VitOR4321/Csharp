using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace NWDV4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            Random r1 = new Random();
            Random r2 = new Random();
            int y = r2.Next(0, int.MaxValue);
            int x= r1.Next(y, int.MaxValue);
            int NWD2 = NWDR(x, y);

            while (NWD2 != 1)
            {
                x = r1.Next(y, int.MaxValue);
                y = r2.Next(0, int.MaxValue);
                NWD2 = NWDR(x, y);


            }
            Console.WriteLine("Wynik wynosi:");
            Console.WriteLine(x);
            watch.Stop();
            
            Console.WriteLine("Czas: {0}", watch.Elapsed);
            Console.ReadKey(true);
        }
        static int NWDR(int x, int y)
        {
            int R = 0;
            while (y != 0)
            {
                R = x % y;
                x = y;
                y = R;
               

            }

            return x;

        }

    }
}