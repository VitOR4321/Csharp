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
            Int32 f1,f2;//f1-figura pierwsza,f2-figura druga
            double a, b, h,r,p1,p2,wynik;
            
            Console.WriteLine("Dzień dobry program sumuje 2 wybrane przez użytkownika pola figur ");
            Console.WriteLine("proszę wprowadzić 2 wybrane figury z listy na której znajduje się po 5 figur płaskich i przestrzennych ");
            Console.WriteLine("Figury sa ponumerowane liczbami, proszę podać liczbę która jest przypisana do danej figury:");
            Console.WriteLine("1-kwadrat");
            Console.WriteLine("2-prostokąt");
            Console.WriteLine("3-równoległobok");
            Console.WriteLine("4-trójkąt");
            Console.WriteLine("5-trapez");
            Console.WriteLine("6-sześcian");
            Console.WriteLine("7-prostopadłościan");
            Console.WriteLine("8-czworościan foremny");
            Console.WriteLine("9-walec");
            Console.WriteLine("10-ostrosłup prawidłowy czworokątny");
            Console.WriteLine("proszę wprowadzić pierwszą figurę:");
            f1 = Int32.Parse(Console.ReadLine());
            switch (f1)
            {
                case 1:
                    {
                        Console.WriteLine("Proszę podać długość boku a: ");
                        a = double.Parse(Console.ReadLine());
                        p1 = kwadrat(a);
                        Console.WriteLine("proszę wprowadzić drugą figurę:");
                        f2 = Int32.Parse(Console.ReadLine());
                        switch (f2)
                        {
                            case 1:
                                {
                                    Console.WriteLine("Proszę podać długość boku a: ");
                                    a = double.Parse(Console.ReadLine());
                                    p2 = kwadrat(a);
                                    wynik = p1 + p2;
                                    Console.WriteLine("Wynik sumy pól wynosi:{0:#.###} ", wynik);

                                }
                                break;
                            case 2:
                                {
                                    Console.WriteLine("Proszę podać długość boku a: ");
                                    a = double.Parse(Console.ReadLine());
                                    Console.WriteLine("Proszę podać długość boku b: ");
                                    b = double.Parse(Console.ReadLine());
                                    p2 = prostokąt(a, b);
                                    wynik = p1 + p2;
                                    Console.WriteLine("Wynik sumy pól wynosi:{0:#.###} ", wynik);
                                }
                                break;
                            case 3:
                                {
                                    Console.WriteLine("Proszę podać długość boku a: ");
                                    a = double.Parse(Console.ReadLine());
                                    Console.WriteLine("Proszę podać długość wysokości h: ");
                                    h = double.Parse(Console.ReadLine());
                                    p2 = równoległobok(a, h);
                                    wynik = p1 + p2;
                                    Console.WriteLine("Wynik sumy pól wynosi:{0:#.###} ", wynik);
                                }
                                break;
                            case 4:
                                {
                                    Console.WriteLine("Proszę podać długość boku a: ");
                                    a = double.Parse(Console.ReadLine());
                                    Console.WriteLine("Proszę podać długość wysokości h: ");
                                    h = double.Parse(Console.ReadLine());
                                    p2 = trójkąt(a, h);
                                    wynik = p1 + p2;
                                    Console.WriteLine("Wynik sumy pól wynosi:{0:#.###} ", wynik);

                                }
                                break;
                            case 5:
                                {
                                    Console.WriteLine("proszę podać długość boku a");
                                    a = Double.Parse(Console.ReadLine());
                                    Console.WriteLine("proszę podać długość boku b");
                                    b = Double.Parse(Console.ReadLine());
                                    Console.WriteLine("proszę podać długość wysokości h");
                                    h = Double.Parse(Console.ReadLine());
                                    p2 = trapez(a, b, h);
                                    wynik = p1 + p2;
                                    Console.WriteLine("Wynik sumy pól wynosi:{0:#.###} ", wynik);
                                }
                                break;
                            case 6:
                                {
                                    Console.WriteLine("proszę podać długość boku a");
                                    a = Double.Parse(Console.ReadLine());
                                    p2 = sześcian(a);
                                    wynik = p1 + p2;
                                    Console.WriteLine("Wynik sumy pól wynosi:{0:#.###} ", wynik);
                                }
                                break;
                            case 7:
                                {
                                    Console.WriteLine("proszę podać długość boku a");
                                    a = Double.Parse(Console.ReadLine());
                                    Console.WriteLine("proszę podać długość boku b");
                                    b = Double.Parse(Console.ReadLine());
                                    Console.WriteLine("proszę podać długość wysokości h");
                                    h = Double.Parse(Console.ReadLine());
                                    p2 = prostopadłościan(a, b, h);
                                    wynik = p1 + p2;
                                    Console.WriteLine("Wynik sumy pól wynosi:{0:#.###} ", wynik);
                                }
                                break;
                            case 8:
                                {
                                    Console.WriteLine("proszę podać długość boku a");
                                    a = Double.Parse(Console.ReadLine());
                                    h = (a * Math.Sqrt(3)) / 2;
                                    p2 = czworościan_foremny(a, h);
                                    wynik = p1 + p2;
                                    Console.WriteLine("Wynik sumy pól wynosi:{0:#.###} ", wynik);

                                }
                                break;
                            case 9:
                                {
                                    Console.WriteLine("proszę podać długość promienia r");
                                    r = Double.Parse(Console.ReadLine());
                                    Console.WriteLine("proszę podać długość wysokości h");
                                    h = Double.Parse(Console.ReadLine());
                                    p2 = walec(r, h);
                                    wynik = p1 + p2;
                                    Console.WriteLine("Wynik sumy pól wynosi:{0:#.###} ", wynik);
                                }
                                break;
                            case 10:
                                {
                                    Console.WriteLine("proszę podać długość podstawy a");
                                    a = Double.Parse(Console.ReadLine());
                                    Console.WriteLine("proszę podać długość wysokości  h");
                                    h = Double.Parse(Console.ReadLine());
                                    p2 = ostrosłup_prawidłowy_czworokątny(a);
                                    wynik = p1 + p2;
                                    Console.WriteLine("Wynik sumy pól wynosi:{0:#.###} ", wynik);


                                }
                                break;
                            default:
                                {

                                    Console.WriteLine("proszę podać poprawną liczbę");
                                }
                                break;
                        }
                    }
                    break;
                case 2:
                    {
                        Console.WriteLine("Proszę podać długość boku a: ");
                        a = double.Parse(Console.ReadLine());
                        Console.WriteLine("Proszę podać długość boku b: ");
                        b = double.Parse(Console.ReadLine());
                        p1 = prostokąt(a,b);
                        Console.WriteLine("proszę wprowadzić drugą figurę:");
                        f2 = Int32.Parse(Console.ReadLine());
                        switch (f2)
                        {
                            case 1:
                                {
                                    Console.WriteLine("Proszę podać długość boku a: ");
                                    a = double.Parse(Console.ReadLine());
                                    p2 = kwadrat(a);
                                    wynik = p1 + p2;
                                    Console.WriteLine("Wynik sumy pól wynosi:{0:#.###} ", wynik);

                                }
                                break;
                            case 2:
                                {
                                    Console.WriteLine("Proszę podać długość boku a: ");
                                    a = double.Parse(Console.ReadLine());
                                    Console.WriteLine("Proszę podać długość boku b: ");
                                    b = double.Parse(Console.ReadLine());
                                    p2 = prostokąt(a, b);
                                    wynik = p1 + p2;
                                    Console.WriteLine("Wynik sumy pól wynosi:{0:#.###} ", wynik);
                                }
                                break;
                            case 3:
                                {
                                    Console.WriteLine("Proszę podać długość boku a: ");
                                    a = double.Parse(Console.ReadLine());
                                    Console.WriteLine("Proszę podać długość wysokości h: ");
                                    h = double.Parse(Console.ReadLine());
                                    p2 = równoległobok(a, h);
                                    wynik = p1 + p2;
                                    Console.WriteLine("Wynik sumy pól wynosi:{0:#.###} ", wynik);
                                }
                                break;
                            case 4:
                                {
                                    Console.WriteLine("Proszę podać długość boku a: ");
                                    a = double.Parse(Console.ReadLine());
                                    Console.WriteLine("Proszę podać długość wysokości h: ");
                                    h = double.Parse(Console.ReadLine());
                                    p2 = trójkąt(a, h);
                                    wynik = p1 + p2;
                                    Console.WriteLine("Wynik sumy pól wynosi:{0:#.###} ", wynik);

                                }
                                break;
                            case 5:
                                {
                                    Console.WriteLine("proszę podać długość boku a");
                                    a = Double.Parse(Console.ReadLine());
                                    Console.WriteLine("proszę podać długość boku b");
                                    b = Double.Parse(Console.ReadLine());
                                    Console.WriteLine("proszę podać długość wysokości h");
                                    h = Double.Parse(Console.ReadLine());
                                    p2 = trapez(a, b, h);
                                    wynik = p1 + p2;
                                    Console.WriteLine("Wynik sumy pól wynosi:{0:#.###} ", wynik);
                                }
                                break;
                            case 6:
                                {
                                    Console.WriteLine("proszę podać długość boku a");
                                    a = Double.Parse(Console.ReadLine());
                                    p2 = sześcian(a);
                                    wynik = p1 + p2;
                                    Console.WriteLine("Wynik sumy pól wynosi:{0:#.###} ", wynik);
                                }
                                break;
                            case 7:
                                {
                                    Console.WriteLine("proszę podać długość boku a");
                                    a = Double.Parse(Console.ReadLine());
                                    Console.WriteLine("proszę podać długość boku b");
                                    b = Double.Parse(Console.ReadLine());
                                    Console.WriteLine("proszę podać długość wysokości h");
                                    h = Double.Parse(Console.ReadLine());
                                    p2 = prostopadłościan(a, b, h);
                                    wynik = p1 + p2;
                                    Console.WriteLine("Wynik sumy pól wynosi:{0:#.###} ", wynik);
                                }
                                break;
                            case 8:
                                {
                                    Console.WriteLine("proszę podać długość boku a");
                                    a = Double.Parse(Console.ReadLine());
                                    h = (a * Math.Sqrt(3)) / 2;
                                    p2 = czworościan_foremny(a, h);
                                    wynik = p1 + p2;
                                    Console.WriteLine("Wynik sumy pól wynosi:{0:#.###} ", wynik);

                                }
                                break;
                            case 9:
                                {
                                    Console.WriteLine("proszę podać długość promienia r");
                                    r = Double.Parse(Console.ReadLine());
                                    Console.WriteLine("proszę podać długość wysokości h");
                                    h = Double.Parse(Console.ReadLine());
                                    p2 = walec(r, h);
                                    wynik = p1 + p2;
                                    Console.WriteLine("Wynik sumy pól wynosi:{0:#.###} ", wynik);
                                }
                                break;
                            case 10:
                                {
                                    Console.WriteLine("proszę podać długość podstawy a");
                                    a = Double.Parse(Console.ReadLine());
                                    Console.WriteLine("proszę podać długość wysokości  h");
                                    h = Double.Parse(Console.ReadLine());
                                    p2 = ostrosłup_prawidłowy_czworokątny(a);
                                    wynik = p1 + p2;
                                    Console.WriteLine("Wynik sumy pól wynosi:{0:#.###} ", wynik);


                                }
                                break;
                            default:
                                {

                                    Console.WriteLine("proszę podać poprawną liczbę");
                                }
                                break;
                        }
                    }
                    break;
                case 3:
                    {
                        Console.WriteLine("Proszę podać długość boku a: ");
                        a = double.Parse(Console.ReadLine());
                        Console.WriteLine("Proszę podać długość wysokości h: ");
                        h = double.Parse(Console.ReadLine());
                        p1 = równoległobok(a, h);
                        Console.WriteLine("proszę wprowadzić drugąfigurę:");
                        f2 = Int32.Parse(Console.ReadLine());
                        switch (f2)
                        {
                            case 1:
                                {
                                    Console.WriteLine("Proszę podać długość boku a: ");
                                    a = double.Parse(Console.ReadLine());
                                    p2 = kwadrat(a);
                                    wynik = p1 + p2;
                                    Console.WriteLine("Wynik sumy pól wynosi:{0:#.###} ", wynik);

                                }
                                break;
                            case 2:
                                {
                                    Console.WriteLine("Proszę podać długość boku a: ");
                                    a = double.Parse(Console.ReadLine());
                                    Console.WriteLine("Proszę podać długość boku b: ");
                                    b = double.Parse(Console.ReadLine());
                                    p2 = prostokąt(a, b);
                                    wynik = p1 + p2;
                                    Console.WriteLine("Wynik sumy pól wynosi:{0:#.###} ", wynik);
                                }
                                break;
                            case 3:
                                {
                                    Console.WriteLine("Proszę podać długość boku a: ");
                                    a = double.Parse(Console.ReadLine());
                                    Console.WriteLine("Proszę podać długość wysokości h: ");
                                    h = double.Parse(Console.ReadLine());
                                    p2 = równoległobok(a, h);
                                    wynik = p1 + p2;
                                    Console.WriteLine("Wynik sumy pól wynosi:{0:#.###} ", wynik);
                                }
                                break;
                            case 4:
                                {
                                    Console.WriteLine("Proszę podać długość boku a: ");
                                    a = double.Parse(Console.ReadLine());
                                    Console.WriteLine("Proszę podać długość wysokości h: ");
                                    h = double.Parse(Console.ReadLine());
                                    p2 = trójkąt(a, h);
                                    wynik = p1 + p2;
                                    Console.WriteLine("Wynik sumy pól wynosi:{0:#.###} ", wynik);

                                }
                                break;
                            case 5:
                                {
                                    Console.WriteLine("proszę podać długość boku a");
                                    a = Double.Parse(Console.ReadLine());
                                    Console.WriteLine("proszę podać długość boku b");
                                    b = Double.Parse(Console.ReadLine());
                                    Console.WriteLine("proszę podać długość wysokości h");
                                    h = Double.Parse(Console.ReadLine());
                                    p2 = trapez(a, b, h);
                                    wynik = p1 + p2;
                                    Console.WriteLine("Wynik sumy pól wynosi:{0:#.###} ", wynik);
                                }
                                break;
                            case 6:
                                {
                                    Console.WriteLine("proszę podać długość boku a");
                                    a = Double.Parse(Console.ReadLine());
                                    p2 = sześcian(a);
                                    wynik = p1 + p2;
                                    Console.WriteLine("Wynik sumy pól wynosi:{0:#.###} ", wynik);
                                }
                                break;
                            case 7:
                                {
                                    Console.WriteLine("proszę podać długość boku a");
                                    a = Double.Parse(Console.ReadLine());
                                    Console.WriteLine("proszę podać długość boku b");
                                    b = Double.Parse(Console.ReadLine());
                                    Console.WriteLine("proszę podać długość wysokości h");
                                    h = Double.Parse(Console.ReadLine());
                                    p2 = prostopadłościan(a, b, h);
                                    wynik = p1 + p2;
                                    Console.WriteLine("Wynik sumy pól wynosi:{0:#.###} ", wynik);
                                }
                                break;
                            case 8:
                                {
                                    Console.WriteLine("proszę podać długość boku a");
                                    a = Double.Parse(Console.ReadLine());
                                    h = (a * Math.Sqrt(3)) / 2;
                                    p2 = czworościan_foremny(a, h);
                                    wynik = p1 + p2;
                                    Console.WriteLine("Wynik sumy pól wynosi:{0:#.###} ", wynik);

                                }
                                break;
                            case 9:
                                {
                                    Console.WriteLine("proszę podać długość promienia r");
                                    r = Double.Parse(Console.ReadLine());
                                    Console.WriteLine("proszę podać długość wysokości h");
                                    h = Double.Parse(Console.ReadLine());
                                    p2 = walec(r, h);
                                    wynik = p1 + p2;
                                    Console.WriteLine("Wynik sumy pól wynosi:{0:#.###} ", wynik);
                                }
                                break;
                            case 10:
                                {
                                    Console.WriteLine("proszę podać długość podstawy a");
                                    a = Double.Parse(Console.ReadLine());
                                    Console.WriteLine("proszę podać długość wysokości  h");
                                    h = Double.Parse(Console.ReadLine());
                                    p2 = ostrosłup_prawidłowy_czworokątny(a);
                                    wynik = p1 + p2;
                                    Console.WriteLine("Wynik sumy pól wynosi:{0:#.###} ", wynik);


                                }
                                break;
                            default:
                                {

                                    Console.WriteLine("proszę podać poprawną liczbę");
                                }
                                break;
                        }
                    }
                    break;
                case 4:
                    {
                        Console.WriteLine("Proszę podać długość boku a: ");
                        a = double.Parse(Console.ReadLine());
                        Console.WriteLine("Proszę podać długość wysokości h: ");
                        h = double.Parse(Console.ReadLine());
                        p1 = trójkąt(a, h);
                        Console.WriteLine("proszę wprowadzić drugą figurę:");
                        f2 = Int32.Parse(Console.ReadLine());
                        switch (f2)
                        {
                            case 1:
                                {
                                    Console.WriteLine("Proszę podać długość boku a: ");
                                    a = double.Parse(Console.ReadLine());
                                    p2 = kwadrat(a);
                                    wynik = p1 + p2;
                                    Console.WriteLine("Wynik sumy pól wynosi:{0:#.###} ", wynik);

                                }
                                break;
                            case 2:
                                {
                                    Console.WriteLine("Proszę podać długość boku a: ");
                                    a = double.Parse(Console.ReadLine());
                                    Console.WriteLine("Proszę podać długość boku b: ");
                                    b = double.Parse(Console.ReadLine());
                                    p2 = prostokąt(a, b);
                                    wynik = p1 + p2;
                                    Console.WriteLine("Wynik sumy pól wynosi:{0:#.###} ", wynik);
                                }
                                break;
                            case 3:
                                {
                                    Console.WriteLine("Proszę podać długość boku a: ");
                                    a = double.Parse(Console.ReadLine());
                                    Console.WriteLine("Proszę podać długość wysokości h: ");
                                    h = double.Parse(Console.ReadLine());
                                    p2 = równoległobok(a, h);
                                    wynik = p1 + p2;
                                    Console.WriteLine("Wynik sumy pól wynosi:{0:#.###} ", wynik);
                                }
                                break;
                            case 4:
                                {
                                    Console.WriteLine("Proszę podać długość boku a: ");
                                    a = double.Parse(Console.ReadLine());
                                    Console.WriteLine("Proszę podać długość wysokości h: ");
                                    h = double.Parse(Console.ReadLine());
                                    p2 = trójkąt(a, h);
                                    wynik = p1 + p2;
                                    Console.WriteLine("Wynik sumy pól wynosi:{0:#.###} ", wynik);

                                }
                                break;
                            case 5:
                                {
                                    Console.WriteLine("proszę podać długość boku a");
                                    a = Double.Parse(Console.ReadLine());
                                    Console.WriteLine("proszę podać długość boku b");
                                    b = Double.Parse(Console.ReadLine());
                                    Console.WriteLine("proszę podać długość wysokości h");
                                    h = Double.Parse(Console.ReadLine());
                                    p2 = trapez(a, b, h);
                                    wynik = p1 + p2;
                                    Console.WriteLine("Wynik sumy pól wynosi:{0:#.###} ", wynik);
                                }
                                break;
                            case 6:
                                {
                                    Console.WriteLine("proszę podać długość boku a");
                                    a = Double.Parse(Console.ReadLine());
                                    p2 = sześcian(a);
                                    wynik = p1 + p2;
                                    Console.WriteLine("Wynik sumy pól wynosi:{0:#.###} ", wynik);
                                }
                                break;
                            case 7:
                                {
                                    Console.WriteLine("proszę podać długość boku a");
                                    a = Double.Parse(Console.ReadLine());
                                    Console.WriteLine("proszę podać długość boku b");
                                    b = Double.Parse(Console.ReadLine());
                                    Console.WriteLine("proszę podać długość wysokości h");
                                    h = Double.Parse(Console.ReadLine());
                                    p2 = prostopadłościan(a, b, h);
                                    wynik = p1 + p2;
                                    Console.WriteLine("Wynik sumy pól wynosi:{0:#.###} ", wynik);
                                }
                                break;
                            case 8:
                                {
                                    Console.WriteLine("proszę podać długość boku a");
                                    a = Double.Parse(Console.ReadLine());
                                    h = (a * Math.Sqrt(3)) / 2;
                                    p2 = czworościan_foremny(a, h);
                                    wynik = p1 + p2;
                                    Console.WriteLine("Wynik sumy pól wynosi:{0:#.###} ", wynik);

                                }
                                break;
                            case 9:
                                {
                                    Console.WriteLine("proszę podać długość promienia r");
                                    r = Double.Parse(Console.ReadLine());
                                    Console.WriteLine("proszę podać długość wysokości h");
                                    h = Double.Parse(Console.ReadLine());
                                    p2 = walec(r, h);
                                    wynik = p1 + p2;
                                    Console.WriteLine("Wynik sumy pól wynosi:{0:#.###} ", wynik);
                                }
                                break;
                            case 10:
                                {
                                    Console.WriteLine("proszę podać długość podstawy a");
                                    a = Double.Parse(Console.ReadLine());
                                    Console.WriteLine("proszę podać długość wysokości  h");
                                    h = Double.Parse(Console.ReadLine());
                                    p2 = ostrosłup_prawidłowy_czworokątny(a);
                                    wynik = p1 + p2;
                                    Console.WriteLine("Wynik sumy pól wynosi:{0:#.###} ", wynik);


                                }
                                break;
                            default:
                                {

                                    Console.WriteLine("proszę podać poprawną liczbę");
                                }
                                break;
                        }
                       
                    }
                    break;
                case 5:
                    {
                        Console.WriteLine("proszę podać długość boku a");
                        a = Double.Parse(Console.ReadLine());
                        Console.WriteLine("proszę podać długość boku b");
                        b = Double.Parse(Console.ReadLine());
                        Console.WriteLine("proszę podać długość wysokości h");
                        h = Double.Parse(Console.ReadLine());
                        p1 = trapez(a,b,h);
                        Console.WriteLine("proszę wprowadzić drugą figurę:");
                        f2 = Int32.Parse(Console.ReadLine());
                        switch (f2)
                        {
                            case 1:
                                {
                                    Console.WriteLine("Proszę podać długość boku a: ");
                                    a = double.Parse(Console.ReadLine());
                                    p2 = kwadrat(a);
                                    wynik = p1 + p2;
                                    Console.WriteLine("Wynik sumy pól wynosi:{0:#.###} ", wynik);

                                }
                                break;
                            case 2:
                                {
                                    Console.WriteLine("Proszę podać długość boku a: ");
                                    a = double.Parse(Console.ReadLine());
                                    Console.WriteLine("Proszę podać długość boku b: ");
                                    b = double.Parse(Console.ReadLine());
                                    p2 = prostokąt(a, b);
                                    wynik = p1 + p2;
                                    Console.WriteLine("Wynik sumy pól wynosi:{0:#.###} ", wynik);
                                }
                                break;
                            case 3:
                                {
                                    Console.WriteLine("Proszę podać długość boku a: ");
                                    a = double.Parse(Console.ReadLine());
                                    Console.WriteLine("Proszę podać długość wysokości h: ");
                                    h = double.Parse(Console.ReadLine());
                                    p2 = równoległobok(a, h);
                                    wynik = p1 + p2;
                                    Console.WriteLine("Wynik sumy pól wynosi:{0:#.###} ", wynik);
                                }
                                break;
                            case 4:
                                {
                                    Console.WriteLine("Proszę podać długość boku a: ");
                                    a = double.Parse(Console.ReadLine());
                                    Console.WriteLine("Proszę podać długość wysokości h: ");
                                    h = double.Parse(Console.ReadLine());
                                    p2 = trójkąt(a, h);
                                    wynik = p1 + p2;
                                    Console.WriteLine("Wynik sumy pól wynosi:{0:#.###} ", wynik);

                                }
                                break;
                            case 5:
                                {
                                    Console.WriteLine("proszę podać długość boku a");
                                    a = Double.Parse(Console.ReadLine());
                                    Console.WriteLine("proszę podać długość boku b");
                                    b = Double.Parse(Console.ReadLine());
                                    Console.WriteLine("proszę podać długość wysokości h");
                                    h = Double.Parse(Console.ReadLine());
                                    p2 = trapez(a, b, h);
                                    wynik = p1 + p2;
                                    Console.WriteLine("Wynik sumy pól wynosi:{0:#.###} ", wynik);
                                }
                                break;
                            case 6:
                                {
                                    Console.WriteLine("proszę podać długość boku a");
                                    a = Double.Parse(Console.ReadLine());
                                    p2 = sześcian(a);
                                    wynik = p1 + p2;
                                    Console.WriteLine("Wynik sumy pól wynosi:{0:#.###} ", wynik);
                                }
                                break;
                            case 7:
                                {
                                    Console.WriteLine("proszę podać długość boku a");
                                    a = Double.Parse(Console.ReadLine());
                                    Console.WriteLine("proszę podać długość boku b");
                                    b = Double.Parse(Console.ReadLine());
                                    Console.WriteLine("proszę podać długość wysokości h");
                                    h = Double.Parse(Console.ReadLine());
                                    p2 = prostopadłościan(a, b, h);
                                    wynik = p1 + p2;
                                    Console.WriteLine("Wynik sumy pól wynosi:{0:#.###} ", wynik);
                                }
                                break;
                            case 8:
                                {
                                    Console.WriteLine("proszę podać długość boku a");
                                    a = Double.Parse(Console.ReadLine());
                                    h = (a * Math.Sqrt(3)) / 2;
                                    p2 = czworościan_foremny(a, h);
                                    wynik = p1 + p2;
                                    Console.WriteLine("Wynik sumy pól wynosi:{0:#.###} ", wynik);

                                }
                                break;
                            case 9:
                                {
                                    Console.WriteLine("proszę podać długość promienia r");
                                    r = Double.Parse(Console.ReadLine());
                                    Console.WriteLine("proszę podać długość wysokości h");
                                    h = Double.Parse(Console.ReadLine());
                                    p2 = walec(r, h);
                                    wynik = p1 + p2;
                                    Console.WriteLine("Wynik sumy pól wynosi:{0:#.###} ", wynik);
                                }
                                break;
                            case 10:
                                {
                                    Console.WriteLine("proszę podać długość podstawy a");
                                    a = Double.Parse(Console.ReadLine());
                                    Console.WriteLine("proszę podać długość wysokości  h");
                                    h = Double.Parse(Console.ReadLine());
                                    p2 = ostrosłup_prawidłowy_czworokątny(a);
                                    wynik = p1 + p2;
                                    Console.WriteLine("Wynik sumy pól wynosi:{0:#.###} ", wynik);


                                }
                                break;
                            default:
                                {

                                    Console.WriteLine("proszę podać poprawną liczbę");
                                }
                                break;
                        }
                    }
                    break;
                case 6:
                    {
                        Console.WriteLine("proszę podać długość boku a");
                        a = Double.Parse(Console.ReadLine());
                        p1 = sześcian(a);
                        Console.WriteLine("proszę wprowadzić drugą figurę:");
                        f2 = Int32.Parse(Console.ReadLine());
                        switch (f2)
                        {
                            case 1:
                                {
                                    Console.WriteLine("Proszę podać długość boku a: ");
                                    a = double.Parse(Console.ReadLine());
                                    p2 = kwadrat(a);
                                    wynik = p1 + p2;
                                    Console.WriteLine("Wynik sumy pól wynosi:{0:#.###} ", wynik);

                                }
                                break;
                            case 2:
                                {
                                    Console.WriteLine("Proszę podać długość boku a: ");
                                    a = double.Parse(Console.ReadLine());
                                    Console.WriteLine("Proszę podać długość boku b: ");
                                    b = double.Parse(Console.ReadLine());
                                    p2 = prostokąt(a, b);
                                    wynik = p1 + p2;
                                    Console.WriteLine("Wynik sumy pól wynosi:{0:#.###} ", wynik);
                                }
                                break;
                            case 3:
                                {
                                    Console.WriteLine("Proszę podać długość boku a: ");
                                    a = double.Parse(Console.ReadLine());
                                    Console.WriteLine("Proszę podać długość wysokości h: ");
                                    h = double.Parse(Console.ReadLine());
                                    p2 = równoległobok(a, h);
                                    wynik = p1 + p2;
                                    Console.WriteLine("Wynik sumy pól wynosi:{0:#.###} ", wynik);
                                }
                                break;
                            case 4:
                                {
                                    Console.WriteLine("Proszę podać długość boku a: ");
                                    a = double.Parse(Console.ReadLine());
                                    Console.WriteLine("Proszę podać długość wysokości h: ");
                                    h = double.Parse(Console.ReadLine());
                                    p2 = trójkąt(a, h);
                                    wynik = p1 + p2;
                                    Console.WriteLine("Wynik sumy pól wynosi:{0:#.###} ", wynik);

                                }
                                break;
                            case 5:
                                {
                                    Console.WriteLine("proszę podać długość boku a");
                                    a = Double.Parse(Console.ReadLine());
                                    Console.WriteLine("proszę podać długość boku b");
                                    b = Double.Parse(Console.ReadLine());
                                    Console.WriteLine("proszę podać długość wysokości h");
                                    h = Double.Parse(Console.ReadLine());
                                    p2 = trapez(a, b, h);
                                    wynik = p1 + p2;
                                    Console.WriteLine("Wynik sumy pól wynosi:{0:#.###} ", wynik);
                                }
                                break;
                            case 6:
                                {
                                    Console.WriteLine("proszę podać długość boku a");
                                    a = Double.Parse(Console.ReadLine());
                                    p2 = sześcian(a);
                                    wynik = p1 + p2;
                                    Console.WriteLine("Wynik sumy pól wynosi:{0:#.###} ", wynik);
                                }
                                break;
                            case 7:
                                {
                                    Console.WriteLine("proszę podać długość boku a");
                                    a = Double.Parse(Console.ReadLine());
                                    Console.WriteLine("proszę podać długość boku b");
                                    b = Double.Parse(Console.ReadLine());
                                    Console.WriteLine("proszę podać długość wysokości h");
                                    h = Double.Parse(Console.ReadLine());
                                    p2 = prostopadłościan(a, b, h);
                                    wynik = p1 + p2;
                                    Console.WriteLine("Wynik sumy pól wynosi:{0:#.###} ", wynik);
                                }
                                break;
                            case 8:
                                {
                                    Console.WriteLine("proszę podać długość boku a");
                                    a = Double.Parse(Console.ReadLine());
                                    h = (a * Math.Sqrt(3)) / 2;
                                    p2 = czworościan_foremny(a, h);
                                    wynik = p1 + p2;
                                    Console.WriteLine("Wynik sumy pól wynosi:{0:#.###} ", wynik);

                                }
                                break;
                            case 9:
                                {
                                    Console.WriteLine("proszę podać długość promienia r");
                                    r = Double.Parse(Console.ReadLine());
                                    Console.WriteLine("proszę podać długość wysokości h");
                                    h = Double.Parse(Console.ReadLine());
                                    p2 = walec(r, h);
                                    wynik = p1 + p2;
                                    Console.WriteLine("Wynik sumy pól wynosi:{0:#.###} ", wynik);
                                }
                                break;
                            case 10:
                                {
                                    Console.WriteLine("proszę podać długość podstawy a");
                                    a = Double.Parse(Console.ReadLine());
                                    Console.WriteLine("proszę podać długość wysokości  h");
                                    h = Double.Parse(Console.ReadLine());
                                    p2 = ostrosłup_prawidłowy_czworokątny(a);
                                    wynik = p1 + p2;
                                    Console.WriteLine("Wynik sumy pól wynosi:{0:#.###} ", wynik);


                                }
                                break;
                            default:
                                {

                                    Console.WriteLine("proszę podać poprawną liczbę");
                                }
                                break;
                        }

                    }
                    break;
                case 7:
                    {
                        Console.WriteLine("proszę podać długość boku a");
                        a = Double.Parse(Console.ReadLine());
                        Console.WriteLine("proszę podać długość boku b");
                        b = Double.Parse(Console.ReadLine());
                        Console.WriteLine("proszę podać długość wysokości h");
                        h = Double.Parse(Console.ReadLine());
                        p1 = prostopadłościan(a, b, h);
                        Console.WriteLine("proszę wprowadzić drugą figurę:");
                        f2 = Int32.Parse(Console.ReadLine());
                        switch (f2)
                        {
                            case 1:
                                {
                                    Console.WriteLine("Proszę podać długość boku a: ");
                                    a = double.Parse(Console.ReadLine());
                                    p2 = kwadrat(a);
                                    wynik = p1 + p2;
                                    Console.WriteLine("Wynik sumy pól wynosi:{0:#.###} ", wynik);

                                }
                                break;
                            case 2:
                                {
                                    Console.WriteLine("Proszę podać długość boku a: ");
                                    a = double.Parse(Console.ReadLine());
                                    Console.WriteLine("Proszę podać długość boku b: ");
                                    b = double.Parse(Console.ReadLine());
                                    p2 = prostokąt(a, b);
                                    wynik = p1 + p2;
                                    Console.WriteLine("Wynik sumy pól wynosi:{0:#.###} ", wynik);
                                }
                                break;
                            case 3:
                                {
                                    Console.WriteLine("Proszę podać długość boku a: ");
                                    a = double.Parse(Console.ReadLine());
                                    Console.WriteLine("Proszę podać długość wysokości h: ");
                                    h = double.Parse(Console.ReadLine());
                                    p2 = równoległobok(a, h);
                                    wynik = p1 + p2;
                                    Console.WriteLine("Wynik sumy pól wynosi:{0:#.###} ", wynik);
                                }
                                break;
                            case 4:
                                {
                                    Console.WriteLine("Proszę podać długość boku a: ");
                                    a = double.Parse(Console.ReadLine());
                                    Console.WriteLine("Proszę podać długość wysokości h: ");
                                    h = double.Parse(Console.ReadLine());
                                    p2 = trójkąt(a, h);
                                    wynik = p1 + p2;
                                    Console.WriteLine("Wynik sumy pól wynosi:{0:#.###} ", wynik);

                                }
                                break;
                            case 5:
                                {
                                    Console.WriteLine("proszę podać długość boku a");
                                    a = Double.Parse(Console.ReadLine());
                                    Console.WriteLine("proszę podać długość boku b");
                                    b = Double.Parse(Console.ReadLine());
                                    Console.WriteLine("proszę podać długość wysokości h");
                                    h = Double.Parse(Console.ReadLine());
                                    p2 = trapez(a, b, h);
                                    wynik = p1 + p2;
                                    Console.WriteLine("Wynik sumy pól wynosi:{0:#.###} ", wynik);
                                }
                                break;
                            case 6:
                                {
                                    Console.WriteLine("proszę podać długość boku a");
                                    a = Double.Parse(Console.ReadLine());
                                    p2 = sześcian(a);
                                    wynik = p1 + p2;
                                    Console.WriteLine("Wynik sumy pól wynosi:{0:#.###} ", wynik);
                                }
                                break;
                            case 7:
                                {
                                    Console.WriteLine("proszę podać długość boku a");
                                    a = Double.Parse(Console.ReadLine());
                                    Console.WriteLine("proszę podać długość boku b");
                                    b = Double.Parse(Console.ReadLine());
                                    Console.WriteLine("proszę podać długość wysokości h");
                                    h = Double.Parse(Console.ReadLine());
                                    p2 = prostopadłościan(a, b, h);
                                    wynik = p1 + p2;
                                    Console.WriteLine("Wynik sumy pól wynosi:{0:#.###} ", wynik);
                                }
                                break;
                            case 8:
                                {
                                    Console.WriteLine("proszę podać długość boku a");
                                    a = Double.Parse(Console.ReadLine());
                                    h = (a * Math.Sqrt(3)) / 2;
                                    p2 = czworościan_foremny(a, h);
                                    wynik = p1 + p2;
                                    Console.WriteLine("Wynik sumy pól wynosi:{0:#.###} ", wynik);

                                }
                                break;
                            case 9:
                                {
                                    Console.WriteLine("proszę podać długość promienia r");
                                    r = Double.Parse(Console.ReadLine());
                                    Console.WriteLine("proszę podać długość wysokości h");
                                    h = Double.Parse(Console.ReadLine());
                                    p2 = walec(r, h);
                                    wynik = p1 + p2;
                                    Console.WriteLine("Wynik sumy pól wynosi:{0:#.###} ", wynik);
                                }
                                break;
                            case 10:
                                {
                                    Console.WriteLine("proszę podać długość podstawy a");
                                    a = Double.Parse(Console.ReadLine());
                                    Console.WriteLine("proszę podać długość wysokości  h");
                                    h = Double.Parse(Console.ReadLine());
                                    p2 = ostrosłup_prawidłowy_czworokątny(a);
                                    wynik = p1 + p2;
                                    Console.WriteLine("Wynik sumy pól wynosi:{0:#.###} ", wynik);


                                }
                                break;
                            default:
                                {

                                    Console.WriteLine("proszę podać poprawną liczbę");
                                }
                                break;
                        }
                    }
                    break;
                case 8:
                    {
                        Console.WriteLine("proszę podać długość boku a");
                        a = Double.Parse(Console.ReadLine());
                        h = (a * Math.Sqrt(3)) / 2;
                        p1 = czworościan_foremny(a, h);
                        Console.WriteLine("proszę wprowadzić drugą figurę:");
                        f2 = Int32.Parse(Console.ReadLine());
                        switch (f2)
                        {
                            case 1:
                                {
                                    Console.WriteLine("Proszę podać długość boku a: ");
                                    a = double.Parse(Console.ReadLine());
                                    p2 = kwadrat(a);
                                    wynik = p1 + p2;
                                    Console.WriteLine("Wynik sumy pól wynosi:{0:#.###} ", wynik);

                                }
                                break;
                            case 2:
                                {
                                    Console.WriteLine("Proszę podać długość boku a: ");
                                    a = double.Parse(Console.ReadLine());
                                    Console.WriteLine("Proszę podać długość boku b: ");
                                    b = double.Parse(Console.ReadLine());
                                    p2 = prostokąt(a, b);
                                    wynik = p1 + p2;
                                    Console.WriteLine("Wynik sumy pól wynosi:{0:#.###} ", wynik);
                                }
                                break;
                            case 3:
                                {
                                    Console.WriteLine("Proszę podać długość boku a: ");
                                    a = double.Parse(Console.ReadLine());
                                    Console.WriteLine("Proszę podać długość wysokości h: ");
                                    h = double.Parse(Console.ReadLine());
                                    p2 = równoległobok(a, h);
                                    wynik = p1 + p2;
                                    Console.WriteLine("Wynik sumy pól wynosi:{0:#.###} ", wynik);
                                }
                                break;
                            case 4:
                                {
                                    Console.WriteLine("Proszę podać długość boku a: ");
                                    a = double.Parse(Console.ReadLine());
                                    Console.WriteLine("Proszę podać długość wysokości h: ");
                                    h = double.Parse(Console.ReadLine());
                                    p2 = trójkąt(a, h);
                                    wynik = p1 + p2;
                                    Console.WriteLine("Wynik sumy pól wynosi:{0:#.###} ", wynik);

                                }
                                break;
                            case 5:
                                {
                                    Console.WriteLine("proszę podać długość boku a");
                                    a = Double.Parse(Console.ReadLine());
                                    Console.WriteLine("proszę podać długość boku b");
                                    b = Double.Parse(Console.ReadLine());
                                    Console.WriteLine("proszę podać długość wysokości h");
                                    h = Double.Parse(Console.ReadLine());
                                    p2 = trapez(a, b, h);
                                    wynik = p1 + p2;
                                    Console.WriteLine("Wynik sumy pól wynosi:{0:#.###} ", wynik);
                                }
                                break;
                            case 6:
                                {
                                    Console.WriteLine("proszę podać długość boku a");
                                    a = Double.Parse(Console.ReadLine());
                                    p2 = sześcian(a);
                                    wynik = p1 + p2;
                                    Console.WriteLine("Wynik sumy pól wynosi:{0:#.###} ", wynik);
                                }
                                break;
                            case 7:
                                {
                                    Console.WriteLine("proszę podać długość boku a");
                                    a = Double.Parse(Console.ReadLine());
                                    Console.WriteLine("proszę podać długość boku b");
                                    b = Double.Parse(Console.ReadLine());
                                    Console.WriteLine("proszę podać długość wysokości h");
                                    h = Double.Parse(Console.ReadLine());
                                    p2 = prostopadłościan(a, b, h);
                                    wynik = p1 + p2;
                                    Console.WriteLine("Wynik sumy pól wynosi:{0:#.###} ", wynik);
                                }
                                break;
                            case 8:
                                {
                                    Console.WriteLine("proszę podać długość boku a");
                                    a = Double.Parse(Console.ReadLine());
                                    h = (a * Math.Sqrt(3)) / 2;
                                    p2 = czworościan_foremny(a, h);
                                    wynik = p1 + p2;
                                    Console.WriteLine("Wynik sumy pól wynosi:{0:#.###} ", wynik);

                                }
                                break;
                            case 9:
                                {
                                    Console.WriteLine("proszę podać długość promienia r");
                                    r = Double.Parse(Console.ReadLine());
                                    Console.WriteLine("proszę podać długość wysokości h");
                                    h = Double.Parse(Console.ReadLine());
                                    p2 = walec(r, h);
                                    wynik = p1 + p2;
                                    Console.WriteLine("Wynik sumy pól wynosi:{0:#.###} ", wynik);
                                }
                                break;
                            case 10:
                                {
                                    Console.WriteLine("proszę podać długość podstawy a");
                                    a = Double.Parse(Console.ReadLine());
                                    Console.WriteLine("proszę podać długość wysokości  h");
                                    h = Double.Parse(Console.ReadLine());
                                    p2 = ostrosłup_prawidłowy_czworokątny(a);
                                    wynik = p1 + p2;
                                    Console.WriteLine("Wynik sumy pól wynosi:{0:#.###} ", wynik);


                                }
                                break;
                            default:
                                {

                                    Console.WriteLine("proszę podać poprawną liczbę");
                                }
                                break;
                        }
                        
                    }
                    break;
                case 9:
                    {
                        Console.WriteLine("proszę podać długość promienia r");
                        r = Double.Parse(Console.ReadLine());
                        Console.WriteLine("proszę podać długość wysokości h");
                        h = Double.Parse(Console.ReadLine());
                        p1 = walec(r, h);
                        Console.WriteLine("proszę wprowadzić drugą figurę:");
                        f2 = Int32.Parse(Console.ReadLine());
                        switch (f2)
                        {
                            case 1:
                                {
                                    Console.WriteLine("Proszę podać długość boku a: ");
                                    a = double.Parse(Console.ReadLine());
                                    p2 = kwadrat(a);
                                    wynik = p1 + p2;
                                    Console.WriteLine("Wynik sumy pól wynosi:{0:#.###} ", wynik);

                                }
                                break;
                            case 2:
                                {
                                    Console.WriteLine("Proszę podać długość boku a: ");
                                    a = double.Parse(Console.ReadLine());
                                    Console.WriteLine("Proszę podać długość boku b: ");
                                    b = double.Parse(Console.ReadLine());
                                    p2 = prostokąt(a, b);
                                    wynik = p1 + p2;
                                    Console.WriteLine("Wynik sumy pól wynosi:{0:#.###} ", wynik);
                                }
                                break;
                            case 3:
                                {
                                    Console.WriteLine("Proszę podać długość boku a: ");
                                    a = double.Parse(Console.ReadLine());
                                    Console.WriteLine("Proszę podać długość wysokości h: ");
                                    h = double.Parse(Console.ReadLine());
                                    p2 = równoległobok(a, h);
                                    wynik = p1 + p2;
                                    Console.WriteLine("Wynik sumy pól wynosi:{0:#.###} ", wynik);
                                }
                                break;
                            case 4:
                                {
                                    Console.WriteLine("Proszę podać długość boku a: ");
                                    a = double.Parse(Console.ReadLine());
                                    Console.WriteLine("Proszę podać długość wysokości h: ");
                                    h = double.Parse(Console.ReadLine());
                                    p2 = trójkąt(a, h);
                                    wynik = p1 + p2;
                                    Console.WriteLine("Wynik sumy pól wynosi:{0:#.###} ", wynik);

                                }
                                break;
                            case 5:
                                {
                                    Console.WriteLine("proszę podać długość boku a");
                                    a = Double.Parse(Console.ReadLine());
                                    Console.WriteLine("proszę podać długość boku b");
                                    b = Double.Parse(Console.ReadLine());
                                    Console.WriteLine("proszę podać długość wysokości h");
                                    h = Double.Parse(Console.ReadLine());
                                    p2 = trapez(a, b, h);
                                    wynik = p1 + p2;
                                    Console.WriteLine("Wynik sumy pól wynosi:{0:#.###} ", wynik);
                                }
                                break;
                            case 6:
                                {
                                    Console.WriteLine("proszę podać długość boku a");
                                    a = Double.Parse(Console.ReadLine());
                                    p2 = sześcian(a);
                                    wynik = p1 + p2;
                                    Console.WriteLine("Wynik sumy pól wynosi:{0:#.###} ", wynik);
                                }
                                break;
                            case 7:
                                {
                                    Console.WriteLine("proszę podać długość boku a");
                                    a = Double.Parse(Console.ReadLine());
                                    Console.WriteLine("proszę podać długość boku b");
                                    b = Double.Parse(Console.ReadLine());
                                    Console.WriteLine("proszę podać długość wysokości h");
                                    h = Double.Parse(Console.ReadLine());
                                    p2 = prostopadłościan(a, b, h);
                                    wynik = p1 + p2;
                                    Console.WriteLine("Wynik sumy pól wynosi:{0:#.###} ", wynik);
                                }
                                break;
                            case 8:
                                {
                                    Console.WriteLine("proszę podać długość boku a");
                                    a = Double.Parse(Console.ReadLine());
                                    h = (a * Math.Sqrt(3)) / 2;
                                    p2 = czworościan_foremny(a, h);
                                    wynik = p1 + p2;
                                    Console.WriteLine("Wynik sumy pól wynosi:{0:#.###} ", wynik);

                                }
                                break;
                            case 9:
                                {
                                    Console.WriteLine("proszę podać długość promienia r");
                                    r = Double.Parse(Console.ReadLine());
                                    Console.WriteLine("proszę podać długość wysokości h");
                                    h = Double.Parse(Console.ReadLine());
                                    p2 = walec(r, h);
                                    wynik = p1 + p2;
                                    Console.WriteLine("Wynik sumy pól wynosi:{0:#.###} ", wynik);
                                }
                                break;
                            case 10:
                                {
                                    Console.WriteLine("proszę podać długość podstawy a");
                                    a = Double.Parse(Console.ReadLine());
                                    Console.WriteLine("proszę podać długość wysokości  h");
                                    h = Double.Parse(Console.ReadLine());
                                    p2 = ostrosłup_prawidłowy_czworokątny(a);
                                    wynik = p1 + p2;
                                    Console.WriteLine("Wynik sumy pól wynosi:{0:#.###} ", wynik);


                                }
                                break;
                            default:
                                {

                                    Console.WriteLine("proszę podać poprawną liczbę");
                                }
                                break;
                        }
                    }
                    break;
                case 10:
                    {
                        Console.WriteLine("proszę podać długość podstawy a");
                        a = Double.Parse(Console.ReadLine());
                        Console.WriteLine("proszę podać długość wysokości  h");
                        h = Double.Parse(Console.ReadLine());
                        p1 = ostrosłup_prawidłowy_czworokątny(a);
                        Console.WriteLine("proszę wprowadzić drugą figurę:");
                        f2 = Int32.Parse(Console.ReadLine());
                        switch (f2)
                        {
                            case 1:
                                {
                                    Console.WriteLine("Proszę podać długość boku a: ");
                                    a = double.Parse(Console.ReadLine());
                                    p2 = kwadrat(a);
                                    wynik = p1 + p2;
                                    Console.WriteLine("Wynik sumy pól wynosi:{0:#.###} ", wynik);

                                }
                                break;
                            case 2:
                                {
                                    Console.WriteLine("Proszę podać długość boku a: ");
                                    a = double.Parse(Console.ReadLine());
                                    Console.WriteLine("Proszę podać długość boku b: ");
                                    b = double.Parse(Console.ReadLine());
                                    p2 = prostokąt(a, b);
                                    wynik = p1 + p2;
                                    Console.WriteLine("Wynik sumy pól wynosi:{0:#.###} ", wynik);
                                }
                                break;
                            case 3:
                                {
                                    Console.WriteLine("Proszę podać długość boku a: ");
                                    a = double.Parse(Console.ReadLine());
                                    Console.WriteLine("Proszę podać długość wysokości h: ");
                                    h = double.Parse(Console.ReadLine());
                                    p2 = równoległobok(a, h);
                                    wynik = p1 + p2;
                                    Console.WriteLine("Wynik sumy pól wynosi:{0:#.###} ", wynik);
                                }
                                break;
                            case 4:
                                {
                                    Console.WriteLine("Proszę podać długość boku a: ");
                                    a = double.Parse(Console.ReadLine());
                                    Console.WriteLine("Proszę podać długość wysokości h: ");
                                    h = double.Parse(Console.ReadLine());
                                    p2 = trójkąt(a, h);
                                    wynik = p1 + p2;
                                    Console.WriteLine("Wynik sumy pól wynosi:{0:#.###} ", wynik);

                                }
                                break;
                            case 5:
                                {
                                    Console.WriteLine("proszę podać długość boku a");
                                    a = Double.Parse(Console.ReadLine());
                                    Console.WriteLine("proszę podać długość boku b");
                                    b = Double.Parse(Console.ReadLine());
                                    Console.WriteLine("proszę podać długość wysokości h");
                                    h = Double.Parse(Console.ReadLine());
                                    p2 = trapez(a, b, h);
                                    wynik = p1 + p2;
                                    Console.WriteLine("Wynik sumy pól wynosi:{0:#.###} ", wynik);
                                }
                                break;
                            case 6:
                                {
                                    Console.WriteLine("proszę podać długość boku a");
                                    a = Double.Parse(Console.ReadLine());
                                    p2 = sześcian(a);
                                    wynik = p1 + p2;
                                    Console.WriteLine("Wynik sumy pól wynosi:{0:#.###} ", wynik);
                                }
                                break;
                            case 7:
                                {
                                    Console.WriteLine("proszę podać długość boku a");
                                    a = Double.Parse(Console.ReadLine());
                                    Console.WriteLine("proszę podać długość boku b");
                                    b = Double.Parse(Console.ReadLine());
                                    Console.WriteLine("proszę podać długość wysokości h");
                                    h = Double.Parse(Console.ReadLine());
                                    p2 = prostopadłościan(a, b, h);
                                    wynik = p1 + p2;
                                    Console.WriteLine("Wynik sumy pól wynosi:{0:#.###} ", wynik);
                                }
                                break;
                            case 8:
                                {
                                    Console.WriteLine("proszę podać długość boku a");
                                    a = Double.Parse(Console.ReadLine());
                                    h = (a * Math.Sqrt(3)) / 2;
                                    p2 = czworościan_foremny(a, h);
                                    wynik = p1 + p2;
                                    Console.WriteLine("Wynik sumy pól wynosi:{0:#.###} ", wynik);

                                }
                                break;
                            case 9:
                                {
                                    Console.WriteLine("proszę podać długość promienia r");
                                    r = Double.Parse(Console.ReadLine());
                                    Console.WriteLine("proszę podać długość wysokości h");
                                    h = Double.Parse(Console.ReadLine());
                                    p2 = walec(r, h);
                                    wynik = p1 + p2;
                                    Console.WriteLine("Wynik sumy pól wynosi:{0:#.###} ", wynik);
                                }
                                break;
                            case 10:
                                {
                                    Console.WriteLine("proszę podać długość podstawy a");
                                    a = Double.Parse(Console.ReadLine());
                                    Console.WriteLine("proszę podać długość wysokości  h");
                                    h = Double.Parse(Console.ReadLine());
                                    p2 = ostrosłup_prawidłowy_czworokątny(a);
                                    wynik = p1 + p2;
                                    Console.WriteLine("Wynik sumy pól wynosi:{0:#.###} ", wynik);


                                }
                                break;
                            default:
                                {

                                    Console.WriteLine("proszę podać poprawną liczbę");
                                }
                                break;
                        }
                        
                    }
                    break;
                default:
                    {

                        Console.WriteLine("proszę podać poprawną liczbę");
                    }
                    break;
            }

            Console.ReadKey(true);

        }
        static double kwadrat(double a)
        {
            double p;
            p = a * a;
            return p;
        }
        static double prostokąt(double a, double b)
        {
            double p;
            p = a * b;
            return p;
        }
        static double równoległobok(double a, double h)
        {
            double p;
            p = a * h;
            return p;
        }
        static double trójkąt(double a, double h)
        {
            double p;
            p = (a * h)/2;
            return p;
        }
        static double trapez(double a, double b, double h)
        {
            double p;
            p = ((a+b )*h) / 2;
            return p;
        }
        static double sześcian(double a)
        {
            double p;
            p = (a * a) * 6;
            return p;
        }
        static double prostopadłościan(double a, double b, double h)
        {
            double p;
            p = (a * b) * 2 + (a * h) * 2 + (b * h) * 2;
            return p;
        }
        static double czworościan_foremny(double a, double h)
        {
            double p;
            p = (a * h) * 4;
            return p;
        }
        static double walec(double r, double h)
        {
            double p;
            p = (Math.PI * r) * 2 + (2 * Math.PI * r * h);
            return p;
        }
        static double ostrosłup_prawidłowy_czworokątny(double a)
        {
            double p;
            p = a * a + ((a * 2) / 2) * 4;
            return p;
        }
        static double wynik(double p1,double p2)
        {
            double w;
            w = p1+p2;
            return w;
        }
        


    }
}