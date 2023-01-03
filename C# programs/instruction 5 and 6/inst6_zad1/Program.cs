using System;

namespace inst6_zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] tabsin = new double[] { 0, 10, 20, 30, 40, 50, 60, 70, 80, 90 };
            double[] tabcos = new double[] { 0, 10, 20, 30, 40, 50, 60, 70, 80, 90 };
            int x = tabsin.Length;
            int y = tabcos.Length;
            Console.WriteLine("wartości sinusów: ");
            for (int i=0; i<x;i++)
            {
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("stopnie: {0}", tabsin[i]);
                double c;
                c = sin(tabsin,i);
                Console.WriteLine("radiany: {0}", Math.Sin(c));
                
            }
            Console.WriteLine("wartości cosinusów:");
            for (int j = 0; j < x; j++)
            {
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("stopnie: {0}", tabcos[j]);
                double b;
                b = cos(tabcos,j);
                Console.WriteLine("radiany: {0}",Math.Cos(b));
                
            }
        }
        static double sin(double[] tabsin, int i)
        {
            double a;
            a = (tabsin[i] * (Math.PI) / 180);
            return a;
        }
        static double cos(double[] tabsin, int j)
        {
            double a;
            a = (tabsin[j] * (Math.PI) / 180);
            return a;

        }
    }
}
