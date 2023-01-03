using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics; 

namespace pierwsze_v1
{
    class Program
    {
        static void Main(string[] args)
        {
             Stopwatch watch;
            watch = new Stopwatch();
            Int32 a, b, i;
            Console.WriteLine("Podaj początek przedziału: ");
            a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Podaj koniec przedziału: ");
            b = Int32.Parse(Console.ReadLine());
            watch.Restart();
            for (i = a; i <= b; i++)
            {
                if (pierwsza(a) == 1)
                {

                }
            }
            Console.ReadKey(true);
            }
        static Int32 pierwsza(Int32 a)
        {
            Int32 i;
            Int32 d = 0;
            for (i = 1; i <= a; i++)
            {
                
                if (a / i == 0)
                {
                    d++;
                }
                if (d == 2)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }

            }
  
        }

        }
    }

