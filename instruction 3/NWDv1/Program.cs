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
            double wynik;
            wynik = NWD(x, y);
            Console.WriteLine("NWD wynosi:{0} ",wynik);

            Console.ReadKey(true);
        }
        static double NWD(double x, double y)
        {
            double nd,r;
            while(y!=0)
            {
                r = x % y;
                x = y;
                y = r;
            }
            nd = x;
            return nd;
            
        }

    }

}
