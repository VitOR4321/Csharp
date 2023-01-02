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
            Double d  ,x1, x2, x0;//d-delta,x1 i x2-zmienne gdy delta wyniesie wiecej niż 0,x0-zmienna  gdy delta nie wyniesie wiecej niż 0 
            Int32 a,b,c;//liczby podanwane przez użytkownika
            Console.WriteLine("Proszę podawać liczby całkowite.");
            Console.WriteLine("Podaj liczbe ax^2");
            a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Podaj liczbe bx");
            b = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Podaj liczbe c");
            c = Int32.Parse(Console.ReadLine());
            Console.WriteLine("f(x)={0}x^2+{1}x+{2}",a,b,c);
            d = (b*b) - (4 * a * c);
            if (d<0)//operacja która sprawdza ile wyniesie delta 
            {
                Console.WriteLine("delta jest mniejsza od 0");
            }
            else
            {
                
                switch (d>0)//operacja która sprawdza ile bedzie pierwiatków 
                {
                    case true:
                        {
                            x1 = (-b - Math.Sqrt(d)) / (2 * a);
                            x2 = (-b + Math.Sqrt(d)) / (2 * a);
                            Console.WriteLine("X1 wynosi:");
                            Console.WriteLine("{0:#.###}", x1);
                            Console.WriteLine("X2 wynosi:");
                            Console.WriteLine("{0:#.###}", x2);

                        }
                        break;
                    case false:
                        {
                            x0 = (-b) / (2 * a);
                            Console.WriteLine("X0 wynosi:");
                            Console.WriteLine("{0:#.###}", x0);
                        }
                        break;
                }
            };
            Console.ReadKey(true);
        }
    }

}// ciekawostka wcześniej urzywałem rownania na delte d=(-b^2)-(4*a*c) to działanie było złe gdyż b było wtedy liczba ujemną nie działało potęgowanie.
