using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
namespace pierg10
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch watch;
            watch = new Stopwatch();
            int a=0, b=0, j=0,ile=0;
            int d = 0, ilość = 0;
            Console.WriteLine("Podaj zakres");
            Console.WriteLine("Od:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Do:");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("metoda: Pominięcie podzielników 1 i n");
            ilość = b - a + 1;
            int apom;
            watch.Restart();
            for (apom = a; apom <= b; apom++)
            {
                d = 2; 
                j = 2;
                if (apom != 1) 
                {
                    for (int i = 0; i < apom; i++)
                    {
                        if (apom != j) 
                        {
                            if (apom % j == 0)
                            {
                                d++;
                            }
                        }
                        j++;
                    }
                    if (d == 2)
                    {
                        Console.Write("{0} ", apom);
                        ile++;  
                    }
                }
            }
                Console.WriteLine("");
                Console.WriteLine("jest : {0} liczb pierwszych", ile);
            watch.Stop();
            Console.WriteLine("Czas: {0}", watch.Elapsed);
            Console.ReadKey(true);
            Console.WriteLine("");
            Console.WriteLine("metoda: Do pierwszej wpadki");
            ile = 0;
            watch.Restart();
            for (apom = a; apom <= b; apom++)
            {
                d = 0;
                j = 1;
                if (apom != 1)
                {
                    for (int i = 0; i < apom; i++)
                    {
                        if (apom % j == 0)
                        {
                            d = d + 1;
                            if (d == 3)
                            {
                                break; 
                            }
                        }
                        j++;
                    }
                    if (d == 2)
                    {
                        Console.Write("{0} ", apom);
                        ile++;
                    }
                }
            }
            Console.WriteLine("");
            Console.WriteLine("jest : {0} liczb pierwszych", ile);
            watch.Stop();
            Console.WriteLine("Czas: {0}", watch.Elapsed);
            ile = 0;
            Console.ReadKey(true);
            Console.WriteLine("");
            Console.WriteLine("metoda: Pierwiastek z n");
            watch.Restart();
            for (apom = a; apom <= b; apom++)
            {
                d = 1;
                j = 1;
                if (apom != 1)
                {
                    for (int i = 1; i <= Math.Sqrt(apom); i++)
                    {
                        if (apom % j == 0)
                        {
                            d = d + 1;
                        }
                        j++;
                    }
                    if (d == 2)
                    {
                        Console.Write("{0} ", apom);
                        ile++;
                    }
                }
            }
                Console.WriteLine("");
                Console.WriteLine("jest : {0} liczb pierwszych", ile);
            watch.Stop();
            Console.WriteLine("Czas: {0}", watch.Elapsed);
            Console.ReadKey(true);
            ile = 0;
            Console.WriteLine("");
            Console.WriteLine("metoda: Sito Erastotenesa");
            watch.Restart();
            int[] tab1 = new int[ilość + 1];
            tab1[0] = a;
            for (int i = 1; i < ilość; i++)
            {
                tab1[i] = tab1[i - 1] + 1;
            }
            double maxj = Math.Sqrt(b) + 1;
            for (int pier = 2; pier <= maxj; pier++)
            {
                for (int i = 0; i < ilość; i++)
                {
                    if (tab1[i] != pier)
                    {
                        if (tab1[i] % pier == 0)
                        {
                            tab1[i] = 1;
                        }
                    }
                }
            }
            for (int i = 1; i < ilość; i++)
            {
                if (tab1[i] != 1) 
                {
                    Console.Write("{0} ", tab1[i]);
                    ile++;
                }
            }
                Console.WriteLine("");
                Console.WriteLine("jest : {0} liczb pierwszych", ile);
            watch.Stop();
            Console.WriteLine("Czas: {0}", watch.Elapsed);
            Console.ReadKey(true);   
        }
    }
}
// Napisali: Wiktor Górski,Miłosz Hołbowski, Kamil Grzybek, Kacper Kasprowiak, Błażej Jachimek