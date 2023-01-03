using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NWD6
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong n;
            Console.Write("Proszę podać ilość liczb Fibonacciego: ");
            n = ulong.Parse(Console.ReadLine());
            ulong[] tablica = new ulong[n];
            ulong i, l1 = 1, l2 = 0;
            ulong f = 0;
            ulong[] tabf = new ulong[f];
            for (i = 0; i < n; i++)
            {
                Console.Write(" " + f + " ");
                    f = l1 + l2;
                    l1 = l2;
                    l2 = f;
                    
            }
            
            Console.ReadKey(true);
        }
    }
}
// zmienna ulong zawiera liczby z przedziału od 0 do 18,446,744,073,709,551,615
// dzięki czemu program mozę podać wiecej liczb fibonacciego.
