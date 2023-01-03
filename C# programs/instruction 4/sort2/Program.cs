using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
namespace sort2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random liczba = new Random();
            Int32  a, i;
            Console.Write("Proszę podać ilość liczb: ");
            a = Int32.Parse(Console.ReadLine());
            Int32[] tab1 = new Int32[a];
                for (i = 0; i < a; i++)
                {
                    tab1[i] = liczba.Next(10000, 99999);
                    Console.Write(tab1[i] + " ");
                };
                Console.WriteLine();
                int n = tab1.Length;
            do
            {
                    for (i = 0; i < n-1; i++)
                    {
                        if (tab1[i] > tab1[i+1])
                        {
                            int temp = tab1[i];
                            tab1[i] = tab1[i+1];
                            tab1[i+1] = temp;
                        }
                    }
                    n--;
            } 
            while (n > 1);
            Console.WriteLine("posortowana tablica: ");
            for (i = 0; i < a; i++)
            {
                Console.Write(tab1[i] + " ");
            };
                                           
            Console.ReadKey(true);
        }
    }
}
