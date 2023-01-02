using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tab5
{
    class Program
    {
        static void Main(string[] args)
        {
            ///////////////////////////////////////////////// część programu odpowiedziana za wypisanie i wstawienie losowych liczb do tablicy
            Random liczba = new Random();
            Int32[,] tab1 = new Int32[4, 6];
            Int32 i, j;
            for (i = 0; i < 4; i++)
            {
                for (j = 0; j < 6; j++)
                {
                    tab1[i, j] = liczba.Next(100, 999);
                    Console.Write(tab1[i, j] + " ");
                };
                Console.WriteLine(" ");
            };
            ////////////////////////////////////////////// część programu odpowiedzialna za zsumowanie elementów tablicy
            Int32 s = 0;
            for (i = 0; i < 4; i++)
            for (j = 0; j < 6; j++)
                s += tab1[i, j];
            Console.WriteLine(" ");
                Console.WriteLine("suma elementów tablicy wynosi:{0}", s);
                Console.WriteLine(" ");
            ////////////////////////////////////////////////////////////////// część programu odpoweidzialna za wypisanie najmniejsze i najwiekszej wartości z tablicy
                Int32 max = tab1[0, 0],min =tab1[0,0];
                Int32 maxi=0, maxj=0, mini=0, minj=0;
                for (i = 0; i < 4; i++)
                {

                    for (j = 0; j < 6; j++)
                    {
                        if (tab1[i, j] > max)
                        {

                            max = tab1[i, j];
                            maxi = i;
                            maxj = j;


                        };

                    };
                };
                Console.WriteLine("wiersz:{0},kolumna:{1}", maxi, maxj);
                Console.WriteLine("max:{0}", max);
                for (i = 0; i < 4; i++)
                {

                    for (j = 0; j < 6; j++)
                    {
                        if (tab1[i, j] < min)
                        {

                            max = tab1[i, j];
                            mini = i;
                            minj = j;


                        };

                    };
                };
                Console.WriteLine("wiersz:{0},kolumna:{1}", mini, minj);
                Console.WriteLine("min:{0}", min);
                Console.WriteLine(" ");
            //////////////////////////////////////////////////////////////////////////// część programu wykonująca transpozycje tab1 na tab2
                Int32[,] tab2 = new Int32[6, 4];
                for (i = 0; i < 6; i++)
                {
                    for (j = 0; j < 4; j++)
                    {
                        tab2[i, j] = tab1[j, i];
                        Console.Write(tab2[i, j] + " ");
                    };
                    Console.WriteLine( " ");
                };


               
               
           

            Console.ReadKey(true);
        }
    }
}

