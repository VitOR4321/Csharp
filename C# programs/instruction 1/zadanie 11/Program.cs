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
            Int32  x, a;//x-liczba wylosowana,a-liczba podana przez użytkownika
            x = liczba.Next(0, 100);//sprawdzenie czy program dobrze działa 
            Console.WriteLine(x);
                Console.WriteLine("Dzień dobry komputer wylosował liczbę z przedziału od 0 do 100.");
                Console.WriteLine("Proszę ją odgadnąć, użytkownik ma na to 6 prób.");
                Console.WriteLine("Program pokarzę czy liczba którą użytkownik wpisał jest mniejsza czy większa od wylosowanej. ");
                Console.WriteLine("Powodzenia :) ");
                //////////////////////////////////////////////////
                Console.WriteLine(" ");
                Console.WriteLine("Pierwsza próba:");
                a = Int32.Parse(Console.ReadLine());
                if (a == x)
                {
                    Console.WriteLine("Gratuluję poprawna odpowiedź!!!!");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Niestety zła odpowiedź");
                    switch (a > x)
                    {
                        case true:
                            {
                                Console.WriteLine("podana liczba jest większa od wylosowanej");

                            }
                            break;
                        case false:
                            {
                                Console.WriteLine("podana liczba jest mniejsza od wylosowanej");

                            }
                            break;

                    }
                    ///////////////////////////////////////////////////////////////////
                    Console.WriteLine(" ");
                    Console.WriteLine("Druga próba:");
                    a = Int32.Parse(Console.ReadLine());
                    if (a == x)
                    {
                        Console.WriteLine("Gratuluję poprawna odpowiedź!!!!");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Niestety zła odpowiedź");
                        switch (a > x)
                        {
                            case true:
                                {
                                    Console.WriteLine("podana liczba jest większa od wylosowanej");

                                }
                                break;
                            case false:
                                {
                                    Console.WriteLine("podana liczba jest mniejsza od wylosowanej");

                                }
                                break;

                        }
                        ///////////////////////////////////////////////////////////////
                        Console.WriteLine(" ");
                        Console.WriteLine("Trzecia próba:");
                        a = Int32.Parse(Console.ReadLine());
                        if (a == x)
                        {
                            Console.WriteLine("Gratuluję poprawna odpowiedź!!!!");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Niestety zła odpowiedź");
                            switch (a > x)
                            {
                                case true:
                                    {
                                        Console.WriteLine("podana liczba jest większa od wylosowanej");

                                    }
                                    break;
                                case false:
                                    {
                                        Console.WriteLine("podana liczba jest mniejsza od wylosowanej");

                                    }
                                    break;

                            }
                            ///////////////////////////////////////////
                            Console.WriteLine(" ");
                            Console.WriteLine("Czwarta próba:");
                            a = Int32.Parse(Console.ReadLine());
                            if (a == x)
                            {
                                Console.WriteLine("Gratuluję poprawna odpowiedź!!!!");
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine("Niestety zła odpowiedź");
                                switch (a > x)
                                {
                                    case true:
                                        {
                                            Console.WriteLine("podana liczba jest większa od wylosowanej");

                                        }
                                        break;
                                    case false:
                                        {
                                            Console.WriteLine("podana liczba jest mniejsza od wylosowanej");

                                        }
                                        break;

                                }
                                ///////////////////////////////////////////////////////////////
                                Console.WriteLine(" ");
                                Console.WriteLine("Piąta  próba:");
                                a = Int32.Parse(Console.ReadLine());
                                if (a == x)
                                {
                                    Console.WriteLine("Gratuluję poprawna odpowiedź!!!!");
                                    Console.ReadKey();
                                }
                                else
                                {
                                    Console.WriteLine("Niestety zła odpowiedź");
                                    switch (a > x)
                                    {
                                        case true:
                                            {
                                                Console.WriteLine("podana liczba jest większa od wylosowanej");

                                            }
                                            break;
                                        case false:
                                            {
                                                Console.WriteLine("podana liczba jest mniejsza od wylosowanej");

                                            }
                                            break;

                                    }
                                    ////////////////////////////////////////////////////////////
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Szósta ostatnia próba:");
                                    a = Int32.Parse(Console.ReadLine());
                                    if (a == x)
                                    {
                                        Console.WriteLine("Gratuluję poprawna odpowiedź!!!!");
                                        Console.ReadKey();
                                    }
                                    else
                                    {
                                        Console.WriteLine("Niestety zła odpowiedź");
                                        switch (a > x)
                                        {
                                            case true:
                                                {
                                                    Console.WriteLine("podana liczba jest większa od wylosowanej");
                                                    Console.ReadKey();
                                                }
                                                break;
                                            case false:
                                                {
                                                    Console.WriteLine("podana liczba jest mniejsza od wylosowanej");
                                                    Console.ReadKey();
                                                }
                                                break;

                                        }
                                    }



                                }
                            }
                        }
                    }
                }
            

                    Console.ReadKey();

                }
            }
        }
