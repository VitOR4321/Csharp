using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sort1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random liczba = new Random();
            Int32 k, w, i, j;
            Console.Write("Proszę podać ilość wiersze: ");
            w = Int32.Parse(Console.ReadLine());
            Console.Write("Proszę podać ilość kolumny: ");
            k = Int32.Parse(Console.ReadLine());
            Int32[,] tab1 = new Int32[k,w];
            for (i = 0; i < k; i++)
            {
                for (j = 0; j < w; j++)
                {
                    tab1[i,j] = liczba.Next(10,99);
                    Console.Write(tab1[i,j] + " ");
                };
                Console.WriteLine(); 
            };
            Console.ReadKey(true);
        }
    }
}
