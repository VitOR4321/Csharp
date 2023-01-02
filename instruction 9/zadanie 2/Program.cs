using System;

namespace zadanie_1
{
    class Program
    {
        class Temperatura
        {
            public double Celcius;
        }
        static void Main(string[] args)
        {
            Temperatura Temp1 = new Temperatura();
            Temperatura Temp2 = new Temperatura();
            Temp1.Celcius = 36.6;
            Temp2.Celcius = Temp1.Celcius - 1;
            Console.Write("Temp2 wynosi: " + Temp2.Celcius);
            Console.ReadKey(true);
        }
    }
}
