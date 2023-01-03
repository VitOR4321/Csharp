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
            
            Int32[] tab1 = {9,8,7,6,5,4,3,2,1,0};
            Int32 i, nr = 1;//i-zmienna zawierającą dane z tablicy,nr-numer indeksu
            for (i = 0; i < 10; i++)
            {

                
                Console.WriteLine("{0}:{1} ", nr, tab1[i]);
                nr++;
            }
            Console.ReadKey(true);
        }
    }
}
