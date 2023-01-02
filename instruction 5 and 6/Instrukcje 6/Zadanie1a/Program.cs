using System;

namespace Zadanie1a
{
    class Program
    {
        static void PoliczSinCosA()
        {
            Console.WriteLine("Sinusy:");
            for (int i = 0; i <= 90; i += 10)
            {
                Console.WriteLine("Dla " + i + " stopni: " + Math.Round(Math.Sin(Math.PI * i / 180.0), 6)+" rad");
            }
            Console.WriteLine("------------------------------------------------" + Environment.NewLine + "Cosinusy:");
            for (int i = 0; i <= 90; i += 10)
            {
                Console.WriteLine("Dla " + i + " stopni: " + Math.Round(Math.Cos(Math.PI * i / 180.0), 6) + " rad");
            }
        }
        static void Main(string[] args)
        {
            PoliczSinCosA();
            Console.ReadKey(true);
        }
    }
}
