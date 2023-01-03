using System;

namespace zadanie_7
{
    class Program
    {
        class Temperatura
        {
            public Temperatura()
            {
                Console.Write("Utworzono Konstruktor\n");
            }
            private double celcius;

            public double Celcius
            {
                set { celcius = value; }
                get { return celcius; }
            }
            public double farenheit
            {
                get { return (celcius * 1.8) + 32; }
                set { celcius = ((value - 32) / 1.8); }
            }
        }
        static void Main(string[] args)
        {
            Temperatura temp1 = new Temperatura();

            temp1.Celcius = 26.4;

            Console.Write("temp1 w celciuszach wynosi: " + temp1.Celcius + "\n");
            Console.Write("temp1 w farenheit wynosi: " + temp1.farenheit + "\n");

            temp1.farenheit = 83.4;
            Console.Write("temp1 w farenheit wynosi: " + temp1.farenheit + "\n");
            Console.Write("temp1 w celciuszach wynosi: " + temp1.Celcius + "\n");
            Console.ReadKey(true);
        }
    }
}