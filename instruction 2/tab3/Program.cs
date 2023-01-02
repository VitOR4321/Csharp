using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random liczba = new Random();
            Int32[,] tab1 = new Int32[3,2];
            Int32 i, j;
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    tab1[i,j] = liczba.Next(0, 9);
                    Console.Write(" "+tab1[i,j]);
                };
                Console.WriteLine(" ");
            };
            Console.ReadKey(true);
        }
    }
}
