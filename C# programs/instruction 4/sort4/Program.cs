using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace sort3
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch watch;
            watch = new Stopwatch();
            Random liczba = new Random();
            Int32 i,j,p,pmin,pmax;
            bool przestaw;
            Console.WriteLine("zwykła metoda bombelkowy");
            Console.Write("100 liczb: ");
            Int32[] tab1 = new Int32[100];
            for (i = 0; i < 100; i++)
            {
                tab1[i] = liczba.Next(10000, 99999);
                //Console.Write(tab1[i] + " ");
            };
            Console.WriteLine();
            int n = tab1.Length;
            watch.Restart();
            do
            {
                for (i = 0; i < n - 1; i++)
                {
                    if (tab1[i] > tab1[i + 1])
                    {
                        int temp = tab1[i];
                        tab1[i] = tab1[i + 1];
                        tab1[i + 1] = temp;
                    };
                };
                n--;
            }
            while (n > 1);
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
            watch.Restart();
            do
            {
                for (i = 0; i < n2 - 1; i++)
                {
                    if (tab2[i] > tab2[i + 1])
                    {
                        int temp = tab2[i];
                        tab2[i] = tab2[i + 1];
                        tab2[i + 1] = temp;
                    };
                };
                n2--;
            }
            while (n2 > 1);
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
            int n3 = tab2.Length;
            watch.Restart();
            do
            {
                for (i = 0; i < n3 - 1; i++)
                {
                    if (tab3[i] > tab3[i + 1])
                    {
                        int temp = tab3[i];
                        tab3[i] = tab3[i + 1];
                        tab3[i + 1] = temp;
                    };
                };
                n3--;
            }
            while (n3 > 1);
            watch.Stop();
            Console.WriteLine("Czas: {0}", watch.Elapsed);
            /*Console.WriteLine("posortowana tablica:");
            for (i = 0; i < 10000; i++)
            {
                Console.Write(tab3[i] + " ");
            };
             */
            ///////////////////////////////////////////////////////////////
            Console.WriteLine("");
            Console.WriteLine("2 ulepszona metoda bombelkowy");
            Console.Write("100 liczb: ");
            Int32[] tab4 = new Int32[100];
            for (i = 0; i < 100; i++)
            {
                tab4[i] = liczba.Next(10000, 99999);
               // Console.Write(tab4[i] + " ");
            };
            Console.WriteLine();
            int n4 = tab4.Length;
            watch.Restart();
            for(j=n4-1;j>0;j--)
            {
                 p = 1;
                for (i = 0; i < j;i++ )
                {
                    if (tab4[i] > tab4[i + 1])
                    {
                        int temp = tab4[i];
                        tab4[i] = tab4[i + 1];
                        tab4[i + 1] = temp;
                        p = 0;
                    };
                };
                if (p == 1)
                {
                    break;
                };
            };
            watch.Stop();
            Console.WriteLine("Czas: {0}", watch.Elapsed);
               /* Console.WriteLine("posortowana tablica:");
                for (i = 0; i < 100; i++)
                {
                    Console.Write(tab4[i] + " ");
                };
                 */
            //////////////////////////////////////////////////////////////
            Console.Write("1000 liczb: ");
            Int32[] tab5 = new Int32[1000];
            for (i = 0; i < 1000; i++)
            {
                tab5[i] = liczba.Next(10000, 99999);
                //Console.Write(tab5[i] + " ");
            };
            Console.WriteLine();
            int n5 = tab5.Length;
            watch.Restart();
            for (j = n5 - 1; j > 0; j--)
            {
                p = 1;
                for (i = 0; i < j; i++)
                {
                    if (tab5[i] > tab5[i + 1])
                    {
                        int temp = tab5[i];
                        tab5[i] = tab5[i + 1];
                        tab5[i + 1] = temp;
                        p = 0;
                    };
                    
                };
                if (p == 1)
                {
                    break;
                };
            };
            watch.Stop();
            Console.WriteLine("Czas: {0}", watch.Elapsed);
            /*Console.WriteLine("posortowana tablica:");
            for (i = 0; i < 1000; i++)
            {
                Console.Write(tab5[i] + " ");
            };
             */
            ///////////////////////////////////////////////////////////////////
            Console.Write("10000 liczb: ");
            
            Int32[] tab6 = new Int32[10000];
            for (i = 0; i < 10000; i++)
            {
                tab6[i] = liczba.Next(10000, 99999);
                //Console.Write(tab6[i] + " ");
            };
            Console.WriteLine();
            int n6 = tab6.Length;
            watch.Restart();
            for (j = n6 - 1; j > 0; j--)
            {
                p = 1;
                for (i = 0; i < j; i++)
                {
                    if (tab6[i] > tab6[i + 1])
                    {
                        int temp = tab6[i];
                        tab6[i] = tab6[i + 1];
                        tab6[i + 1] = temp;
                        p = 0;
                    };
                };
                if (p == 1)
                {
                    break;
                };
            };
            watch.Stop();
            Console.WriteLine("Czas: {0}", watch.Elapsed);
            /*Console.WriteLine("posortowana tablica:");
            for (i = 0; i < 10000; i++)
            {
                Console.Write(tab6[i] + " ");
            };
             */
            ///////////////////////////////////////////////////////////////
            Console.WriteLine("");
            Console.WriteLine("1 ulepszona metoda bombelkowy");
            Console.Write("100 liczb: ");
            Int32[] tab7 = new Int32[100];
            for (i = 0; i < 100; i++)
            {
                tab7[i] = liczba.Next(10000, 99999);
                // Console.Write(tab7[i] + " ");
            };
            Console.WriteLine();
            int n7 = tab7.Length;
            watch.Restart();
            for (; ; )
            {
                przestaw = false;
                for (i = 0; i <= n7-2; i++)
                {
                    if(tab7[i]>tab7[i+1])
                    {
                    int temp = tab7[i+1];
                    tab7[i+1] = tab7[i];
                    tab7[i] = temp;
                    przestaw = true;

                    };
                };
                if (!przestaw)
                {
                    break;
                };
            };
            
                watch.Stop();
            Console.WriteLine("Czas: {0}", watch.Elapsed);
            /* Console.WriteLine("posortowana tablica:");
             for (i = 0; i < 100; i++)
             {
                 Console.Write(tab7[i] + " ");
             };
              */
            //////////////////////////////////////////////////////////////
            Console.Write("1000 liczb: ");
            Int32[] tab8 = new Int32[1000];
            for (i = 0; i < 1000; i++)
            {
                tab8[i] = liczba.Next(10000, 99999);
                //Console.Write(tab8[i] + " ");
            };
            Console.WriteLine();
            int n8 = tab8.Length;
            watch.Restart();
            for (; ; )
            {
                przestaw = false;
                for (i = 0; i <= n8-2; i++)
                {
                    if (tab8[i] > tab8[i + 1])
                    {
                        int temp = tab8[i];
                        tab8[i] = tab8[i + 1];
                        tab8[i + 1] = temp;
                        przestaw = true;
                    };
                };
                if (!przestaw)
                {
                    break;
                };
            };
            
            watch.Stop();
            Console.WriteLine("Czas: {0}", watch.Elapsed);
            /*Console.WriteLine("posortowana tablica:");
            for (i = 0; i < 1000; i++)
            {
                Console.Write(tab8[i] + " ");
            };
             */
            ///////////////////////////////////////////////////////////////////
            Console.Write("10000 liczb: ");

            Int32[] tab9 = new Int32[10000];
            for (i = 0; i < 10000; i++)
            {
                tab9[i] = liczba.Next(10000, 99999);
                //Console.Write(tab9[i] + " ");
            };
            Console.WriteLine();
            int n9 = tab9.Length;
            watch.Restart();
            for (; ; )
            {
                przestaw = false;
                for (i = 0; i <= n9-2; i++)
                {
                    if (tab9[i] > tab9[i + 1])
                    {
                        int temp = tab9[i];
                        tab9[i] = tab9[i + 1];
                        tab9[i + 1] = temp;
                        przestaw = true;
                    };
                };
                if (!przestaw)
                {
                    break;
                };
            };
            watch.Stop();
            Console.WriteLine("Czas: {0}", watch.Elapsed);
            /*Console.WriteLine("posortowana tablica:");
            for (i = 0; i < 10000; i++)
            {
                Console.Write(tab9[i] + " ");
            };
             */
            ///////////////////////////////////////////////////////////////
            Console.WriteLine("");
            Console.WriteLine("3 ulepszona metoda bombelkowy");
            Console.Write("100 liczb: ");
            Int32[] tab10 = new Int32[100];
            for (i = 0; i < 100; i++)
            {
                tab10[i] = liczba.Next(10000, 99999);
                 //Console.Write(tab10[i] + " ");
            };
            Console.WriteLine();
            int n10 = tab10.Length;
            watch.Restart();
            pmin = 0;
            pmax = 0;
            do
            {
                p = -1;
                for (i = pmin; i <= pmax; i++)
                {
                    int temp = tab10[i];
                    tab10[i] = tab10[i + 1];
                    tab10[i + 1] = temp;
                    p = 1;
                };
                if (p < 0) break;
                pmax = p - 1;
                p = -1;
                for (i = pmax; i >= pmin; i--)
                {
                    int temp = tab10[i];
                    tab10[i] = tab10[i + 1];
                    tab10[i + 1] = temp;
                    p = 1;
                };
                pmin = p + 1;
            } while (p >= 0);

            watch.Stop();
            Console.WriteLine("Czas: {0}", watch.Elapsed);
            /* Console.WriteLine("posortowana tablica:");
            for (i = 0; i < 100; i++)
             {
                 Console.Write(tab7[i] + " ");
             };
              */
            //////////////////////////////////////////////////////////////
            Console.Write("1000 liczb: ");
            Int32[] tab11 = new Int32[1000];
            for (i = 0; i < 1000; i++)
            {
                tab11[i] = liczba.Next(10000, 99999);
                //Console.Write(tab11[i] + " ");
            };
            Console.WriteLine();
            int n11 = tab11.Length;
            pmin = 0;
            pmax = 0;
            do
            {
                p = -1;
                for (i = pmin; i <= pmax; i++)
                {
                    int temp = tab11[i];
                    tab11[i] = tab11[i + 1];
                    tab11[i + 1] = temp;
                    p = 1;
                };
                if (p < 0) break;
                pmax = p - 1;
                p = -1;
                for (i = pmax; i >= pmin; i--)
                {
                    int temp = tab11[i];
                    tab11[i] = tab11[i + 1];
                    tab11[i + 1] = temp;
                    p = 1;
                };
                pmin = p + 1;
            } while (p >= 0);

            watch.Stop();
            Console.WriteLine("Czas: {0}", watch.Elapsed);
            /*Console.WriteLine("posortowana tablica:");
            for (i = 0; i < 1000; i++)
            {
                Console.Write(tab8[i] + " ");
            };
             */
            ///////////////////////////////////////////////////////////////////
            Console.Write("10000 liczb: ");

            Int32[] tab12 = new Int32[10000];
            for (i = 0; i < 10000; i++)
            {
                tab12[i] = liczba.Next(10000, 99999);
                //Console.Write(tab12[i] + " ");
            };
            Console.WriteLine();
            int n12 = tab12.Length;
            watch.Restart();
            pmin = 0;
            pmax = 0;
            do
            {
                p = -1;
                for (i = pmin; i <= pmax; i++)
                {
                    int temp = tab12[i];
                    tab12[i] = tab12[i + 1];
                    tab12[i + 1] = temp;
                    p = 1;
                };
                if (p < 0) break;
                pmax = p - 1;
                p = -1;
                for (i = pmax; i >= pmin; i--)
                {
                    int temp = tab12[i];
                    tab12[i] = tab12[i + 1];
                    tab12[i + 1] = temp;
                    p = 1;
                };
                pmin = p + 1;
            } while (p >= 0);
            watch.Stop();
            Console.WriteLine("Czas: {0}", watch.Elapsed);
            /*Console.WriteLine("posortowana tablica:");
            for (i = 0; i < 10000; i++)
            {
                Console.Write(tab9[i] + " ");
            };
             */
            Console.ReadKey(true);
        }
    }
}
