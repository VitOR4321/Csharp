using System;


namespace inst7_zad11
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=0, b=0;
            for (; ; )
            {
                
                Console.WriteLine("Proszę podać znak: ");
                string z = Console.ReadLine();
                foreach (char c in z)
                    if (c == '?')
                    {
                        Console.WriteLine("Menu");
                        Console.WriteLine("a- wczytuje liczbę a");
                        Console.WriteLine("b- wczytuje liczbę b");
                        Console.WriteLine("+- oblicza sumę a i b");
                        Console.WriteLine("*- oblicza iloczyn a i b");
                        Console.WriteLine("x- zakańcza program");
                    }
                    else if (c == 'a')
                    {
                        Console.Write("Podaj a: ");
                        a = int.Parse(Console.ReadLine());
                        Console.WriteLine(a);
                    }
                    else if (c == 'b')
                    {
                        Console.Write("Podaj b: ");
                        b = int.Parse(Console.ReadLine());
                        Console.WriteLine(b);
                    }
                    else if (c == '+')
                    {
                        Console.WriteLine("a+b");
                        int s = a + b;
                        Console.WriteLine(s);
                    }
                    else if (c == '*')
                    {
                        Console.WriteLine("a*b");
                        int m = a * b;
                        Console.WriteLine(m);
                    }
                    else if(c == 'x')
                    {

                    System.Environment.Exit(1);
                    }

                    }
    }    
        }
    }

