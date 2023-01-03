using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pier11
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, n,i;
            Console.Write("podaj ilosc liczb pierwszych: ");
            n = int.Parse(Console.ReadLine());
            Console.Write("wieksze od: ");
            a = int.Parse(Console.ReadLine());
            int[] tab=new int[n];
            
            Console.ReadKey(true);
        }
    }
}
