﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inst7_zad5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj łańcuch znaków: ");
            string ciagZnakow = Console.ReadLine();
            string[] tabelaStringow = ciagZnakow.Split(',');
            int[] tabelaIntow = new int[tabelaStringow.Length];
            for (int i = 0; i < tabelaStringow.Length; i++)
            {
                tabelaStringow[i] = tabelaStringow[i].Replace(" ", " ");
                tabelaIntow[i] = int.Parse(tabelaStringow[i]);
                Console.WriteLine("Liczba wynosi:" + tabelaIntow[i] + ", kwadrat wynosi: " + Math.Pow(tabelaIntow[i], 2));
            }
            Console.ReadKey(true);
        }
    }
}