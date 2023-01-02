using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tab_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random liczba = new Random();
            Int32[,] tab1 = new Int32[4, 6];
            Int32 i, j;
            for (i = 0; i < 4; i++)
            {
                for (j = 0; j < 6; j++)
                {
                    tab1[i, j] = liczba.Next(100, 999);
                    Console.Write(tab1[i, j]+" " );
                };
                Console.WriteLine(" ");
            };
            Console.ReadKey(true);
        }
    }
}
