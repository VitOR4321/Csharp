using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tab6
{
    class Program
    {
        static void Main(string[] args)
        {
            ///////////////////////////////////////////////// operacja losująca liczbe, deklarowanie tablicy
            Random liczba = new Random();
            Int32[,] tab1 = new Int32[10, 10];
            Int32 i, j;
            ///////////////////////////////////////////////// podstawianie do tablicy liczb losowych
            for (i = 0; i < 10; i++)
            {
                for (j = 0; j < 10; j++)
                {
                    tab1[i, j] = liczba.Next(0, 999);
                    Console.Write(" "+tab1[i, j] + " ");
                    //////////////////////////////////////////////////// opracja ktora na podstawie długości liczby z tablicy decyduje jaka  bedzie przerwa pomiedzy liczbami
                    int dlugosc = Dl(tab1[i, j]);
                    if (dlugosc == 2)
                    {
                        Console.Write(" ");
                    }
                    else if (dlugosc == 1)
                    {
                        Console.Write("  ");
                    };
                };
                Console.WriteLine(" ");
               
            };
            Console.ReadKey(true);
            
        }
      
       
      
        static int Dl(int liczba)
            /////////////////////////////////////////////// funkcja ktora pobera wartość losowanej liczby i sprawdza  jakiej jest długości
        {
            int d=0;
            if ((100 <= liczba) && (999 <= liczba))
            {
                d=3;
            }
            else if ((10 <= liczba) && (99 <= liczba))
            {
                d = 2;
            }
            else if ((0 <= liczba) && (9 <= liczba))
            {
                d = 1;
            };

            return d;
        }

    }
}
