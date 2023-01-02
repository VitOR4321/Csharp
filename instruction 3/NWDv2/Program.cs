using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NWDv1
{
    class Program
    {
        static void Main(string[] args)
        {
            Double x, y;
            Console.WriteLine("proszę podać piewszą liczbę: ");
            x = Double.Parse(Console.ReadLine());
            Console.WriteLine("proszę podać piewszą liczbę: ");
            y = Double.Parse(Console.ReadLine());
            double wynikv1, wynikv2;
            wynikv1 = NWDv1(x, y);
            Console.WriteLine("NWD przez resztę z dzielenia wynosi:{0} ", wynikv1);
            wynikv2 = NWDv2(x, y);
            Console.WriteLine("NWD przez odejmowanie wynosi:{0} ", wynikv2);

            Console.ReadKey(true);
        }
        static double NWDv1(double x, double y)
        {
            double nd, r;
            double ii1 = 0;
            while (y != 0)
            {
                r = x % y;
                x = y;
                y = r;
                ii1++;

            };

            nd = x;
            return nd;

        }
        static double NWDv2(double x, double y)
        {
            double nd;
            double ii2 = 0;
            while (x != y)
            {
                if (x > y)
                {
                    x = x - y;
                }
                else
                {
                    y = y - x;
                }
                ii2++;
            };
            nd = x;
            return nd;

        }


    }

}
// Funkcja wykonująca NWD z reszty z dzielenia wykonuje mniej iteracji przez co jest lepszym sposobem.
// nie udało mi się wyliczyć liczby iteracji.