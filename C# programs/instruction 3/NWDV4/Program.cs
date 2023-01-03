using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace NWDV4
{
    class Program
    {
        static void Main(string[] args)
        {
          Stopwatch watch = new Stopwatch();
          Console.WriteLine("Podaj liczba : ");
          int y = int.Parse(Console.ReadLine());
            watch.Start();
            Random R = new Random();
            int x = R.Next(y, int.MaxValue);
            int NWD4 = NWDR(x, y);

            while (NWD4 != 1)
            {
                x = R.Next(y, int.MaxValue);
                NWD4 = NWDR(x, y);
            }
            Console.WriteLine("Wynik wynosi:");
            Console.WriteLine(x);
            watch.Stop();
            Console.WriteLine("Czas wynosi: {0}", watch.Elapsed);

            Console.ReadKey(true);
        }
        
      static int NWDR(int x, int y)
        {
            int R = 0;
            ; 
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
