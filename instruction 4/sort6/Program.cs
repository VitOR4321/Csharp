using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace sort6
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch watch;
            watch = new Stopwatch();
            Random liczba = new Random();
            Int32 i;
            Console.WriteLine("Ulepszony gnom");
            Console.Write("100 liczb: ");
            Int32[] tab1 = new Int32[100];
            for (i = 0; i < 100; i++)
            {
                tab1[i] = liczba.Next(10000, 99999);
                //Console.Write(tab1[i] + " ");
            };
            Console.WriteLine();
            int n = tab1.Length;
            int p = 0;
            int ost_p = 0;
            watch.Restart();
            while (p < n)
            {
                if (p == 0 || tab1[p] >= tab1[p - 1])
                {
                    p = ost_p + 1;
                    ost_p = p;
                }
                else
                {
                    int temp = tab1[p];
                    tab1[p] = tab1[p - 1];
                    tab1[p - 1] = temp;
                    p--;
                }
            };
            watch.Stop();
            Console.WriteLine("Czas: {0}", watch.Elapsed);
            /*Console.WriteLine("posortowana tablica:");
            for (i = 0; i < 100; i++)
            {
                Console.Write(tab1[i] + " ");
            };
             */
            //////////////////////////////////////////////////////////////
            Console.Write("1000 liczb: ");
            Int32[] tab2 = new Int32[1000];
            for (i = 0; i < 1000; i++)
            {
                tab2[i] = liczba.Next(10000, 99999);
                //Console.Write(tab2[i] + " ");
            };
            Console.WriteLine();
            int n2 = tab2.Length;
            int p2 = 0;
            int ost_p2 = 0;
            watch.Restart();
            while (p2 < n2)
            {
                if (p2 == 0 || tab2[p2] >= tab2[p2 - 1])
                {
                    p2 = ost_p2 + 1;
                    ost_p2 = p2;
                }
                else
                {
                    int temp = tab2[p2];
                    tab2[p2] = tab2[p2 - 1];
                    tab2[p2 - 1] = temp;
                    p2--;
                }
            };
            watch.Stop();
            Console.WriteLine("Czas: {0}", watch.Elapsed);
            /*Console.WriteLine("posortowana tablica:");
            for (i = 0; i < 1000; i++)
            {
                Console.Write(tab2[i] + " ");
            };
             */
            ///////////////////////////////////////////////////////////////////
            Console.Write("10000 liczb: ");
            Int32[] tab3 = new Int32[10000];
            for (i = 0; i < 10000; i++)
            {
                tab3[i] = liczba.Next(10000, 99999);
                //Console.Write(tab2[i] + " ");
            };
            Console.WriteLine();
            int n3 = tab3.Length;
            int p3 = 0;
            int ost_p3 = 0;
            watch.Restart();
            while (p3 < n3)
            {
                if (p3 == 0 || tab3[p3] >= tab3[p3 - 1])
                {
                    p3 = ost_p3 + 1;
                    ost_p3 = p3;
                }
                else
                {
                    int temp = tab3[p3];
                    tab3[p3] = tab3[p3 - 1];
                    tab3[p3 - 1] = temp;
                    p3--;
                };
            };
            watch.Stop();
            Console.WriteLine("Czas: {0}", watch.Elapsed);
            /*Console.WriteLine("posortowana tablica:");
            for (i = 0; i < 10000; i++)
            {
                Console.Write(tab3[i] + " ");
            };
             */
           

            Console.ReadKey(true);
        }
    }
}
