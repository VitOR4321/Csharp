using System;
using System.Threading.Tasks;

namespace inst7_zad12
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo c;
            int a=0;
            int b=0;
            int end=0;
            int działanie;
            do
            {
                c = Console.ReadKey();
                if (c.Key == ConsoleKey.M)
                {
                    Console.WriteLine("Menu");
                    Console.WriteLine("a- wczytuje liczbę a");
                    Console.WriteLine("b- wczytuje liczbę b");
                    Console.WriteLine("s- oblicza sumę a i b");
                    Console.WriteLine("i- oblicza iloczyn a i b");
                    Console.WriteLine("x- zakańcza program");
                }
                else if (c.Key == ConsoleKey.A)
                {
                    Console.Write("Podaj a: ");
                    a = int.Parse(Console.ReadLine());
                    Console.WriteLine(a);
                }
                else if (c.Key == ConsoleKey.B)
                {
                    Console.Write("Podaj b: ");
                    b = int.Parse(Console.ReadLine());
                    Console.WriteLine(b);
                }
                else if (c.Key == ConsoleKey.S)
                {
                    Console.WriteLine("a+b");
                    działanie = a + b;
                    Console.WriteLine(działanie);
                }
                else if (c.Key == ConsoleKey.I)
                {
                    Console.WriteLine("a*b");
                    działanie = a * b;
                    Console.WriteLine(działanie);
                }
                else if (c.Key == ConsoleKey.X)
                {
                    end = 1;
                }
            } while (end == 0);
        }
    }
}
