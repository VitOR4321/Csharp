using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random liczba = new Random();
            Int32[] tab1 = new Int32[20];
            Int32 i,nr=1;//i-zmienna zawierającą dane z tablicy,nr-numer indeksu
            for (i = 0; i < 20; i++)
            {
                
                tab1[i] = liczba.Next(0, 9);
                Console.Write("{0}:{1} ", nr,tab1[i]);
                nr++;
            }
            Console.ReadKey(true);
        }
    }
}
