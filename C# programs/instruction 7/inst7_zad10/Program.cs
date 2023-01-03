using System;
using System.Threading.Tasks;
namespace inst7_zad10
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo d = Console.ReadKey();
            for (; ; )
            {
                Console.WriteLine("Urzyto znaku: {0}",d.Key);
                // sekwencja wyjścia z programu control + E
                if(d.Key == ConsoleKey.E && (d.Modifiers & ConsoleModifiers.Control)!=0)
                {
                    break;
                }
                d = Console.ReadKey();
            }
           
        }
    }
}
