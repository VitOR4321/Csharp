using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics; 

namespace pierwsze_pierwiastek
{
    class Program
    {
        static void Main(string[] args)
        {

            int num, ctr;
            Console.Write("Enter number: ");
            num = int.Parse(Console.ReadLine());
            int[] inp = new int[num];

            for (ctr = 0; ctr < num; ctr++)
            {
                Console.Write("\n\nEnter number {0}: ", ctr + 1);
                inp[ctr] = int.Parse(Console.ReadLine());
                double sqrt = Math.Sqrt(inp[ctr]);
                Console.Write("\nSquare root: {0} ", sqrt);
                int cnvt = inp[ctr];

                Console.Write("\nNearest prime number/s: ");
                int i, Prime1 = 0, Prime2 = 0;
                bool checkPrime1 = true, checkPrime2 = true;

                while (checkPrime1)
                {
                    cnvt--;
                    for (i = 2; i <= cnvt; i++)
                    {
                        if (cnvt % i == 0)
                        {
                            break;
                        }
                    }
                    if (i == cnvt)
                    {
                        checkPrime1 = false;
                        Prime1 = cnvt;
                        break;
                    }
                }

                while (checkPrime2)
                {
                    cnvt++;
                    for (i = 2; i <= cnvt; i++)
                    {
                        if (cnvt % i == 0)
                        {
                            break;
                        }
                    }
                    if (i == cnvt)
                    {
                        Prime2 = cnvt;
                        checkPrime2 = false;
                        break;
                    }
                }

                if (Prime2 - cnvt > cnvt - Prime1)
                {
                    Console.WriteLine(Prime1);
                }

                else if (Prime2 - cnvt < cnvt - Prime1)
                {
                    Console.WriteLine(Prime2);
                }

                else if (Prime2 - cnvt == cnvt - Prime1)
                {
                    Console.WriteLine(Prime1 + ", " + Prime2);
                }
            }

            Console.ReadLine();
        }
    }
}