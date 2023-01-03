using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace pierg11
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, j, ile = 0; // tu był błąd j=1 trzeba dać w pętli while
            int d = 0;
            Console.WriteLine("ile liczb:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("od jakiej liczby:");
            b = int.Parse(Console.ReadLine());
            int apom;
            apom = b - 1;
            int[] tab1 = new int[a];
            while (ile != a)
            {
                apom++;
                d = 0;
                j = 1;// teraz dobrze
                for (int i = 0; i < apom; i++)
                {
                    if (apom % j == 0)
                    {
                        d = d + 1;
                    }
                    j++;
                }
                if (d == 2)
                {
                    tab1[ile] = apom;
                    ile++;
                }
            }
            Console.WriteLine("jest : {0} liczb pierwszych", ile);
            Console.Write("Liczby w tablicy:");
            for (int i = 0; i < a; i++)
            {
                Console.Write(" {0} ", tab1[i]);
            }
            Console.ReadKey(true);
            
        }
    }
}
// Napisali: Wiktor Górski,Miłosz Hołbowski, Kamil Grzybek, Kacper Kasprowiak, Błażej Jachimek
// Błędem była źle zadeklarowa wartość zmienne "j", po zmianie miejsca deklaracji wyświetla wartość.