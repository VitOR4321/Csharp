using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace sort5
{
    class Program
    {
        static void Main(string[] args)
       {
            Stopwatch watch;
            watch = new Stopwatch();
            Random liczba = new Random();
            Int32 i;
            Console.WriteLine("Zwykły gnom");
            Console.Write("100 liczb: ");
            watch.Restart();
            Int32[] tab1 = new Int32[100];
            for (i = 0; i < 100; i++)
            {
                tab1[i] = liczba.Next(10000, 99999);
                //Console.Write(tab1[i] + " ");
            };
            Console.WriteLine();
            int n = tab1.Length;
            i = 0;
            while(i<n)
            {
                if (i == 0)
                {
                    i++;
                }
                if (tab1[i] >= tab1[i - 1])
                {
                    i++;
                }
                else
                {
                    int temp = tab1[i];
                    tab1[i] = tab1[i - 1];
                    tab1[i - 1] = temp;
                    i--;
                    
                }

            }
            /*Console.WriteLine("posortowana tablica:");
            for (i = 0; i < 100; i++)
            {
                Console.Write(tab1[i] + " ");
            };
             */
            watch.Stop();
            Console.WriteLine("Czas: {0}", watch.Elapsed);
            //////////////////////////////////////////////////////////////
            Console.Write("1000 liczb: ");
            watch.Restart();
            Int32[] tab2 = new Int32[1000];
            for (i = 0; i < 1000; i++)
            {
                tab2[i] = liczba.Next(10000, 99999);
                //Console.Write(tab2[i] + " ");
            };
            Console.WriteLine();
            int n2 = tab2.Length;
            i = 0;
            while (i < n2)
            {
                if (i == 0)
                {
                    i++;
                }
                if (tab2[i] >= tab2[i - 1])
                {
                    i++;
                }
                else
                {
                    int temp = tab2[i];
                    tab2[i] = tab2[i - 1];
                    tab2[i - 1] = temp;
                    i--;

                }

            }
            /*Console.WriteLine("posortowana tablica:");
            for (i = 0; i < 1000; i++)
            {
                Console.Write(tab2[i] + " ");
            };
             */
            watch.Stop();
            Console.WriteLine("Czas: {0}", watch.Elapsed);
            ///////////////////////////////////////////////////////////////////
            Console.Write("10000 liczb: ");
            watch.Restart();
            Int32[] tab3 = new Int32[10000];
            for (i = 0; i < 10000; i++)
            {
                tab3[i] = liczba.Next(10000, 99999);
                //Console.Write(tab2[i] + " ");
            };
            Console.WriteLine();
            int n3 = tab3.Length;
            i = 0;
            while (i < n3)
            {
                if (i == 0)
                {
                    i++;
                }
                if (tab3[i] >= tab3[i - 1])
                {
                    i++;
                }
                else
                {
                    int temp = tab3[i];
                    tab3[i] = tab3[i - 1];
                    tab3[i - 1] = temp;
                    i--;

                }

            }
            /*Console.WriteLine("posortowana tablica:");
            for (i = 0; i < 10000; i++)
            {
                Console.Write(tab3[i] + " ");
            };
             */
            watch.Stop();
            Console.WriteLine("Czas: {0}", watch.Elapsed);

            Console.ReadKey(true);
        }
    }
}
