using System;

namespace zadanie_8
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
            public override string ToString()
            {
                return " Temperatura wynosi " + celcius + " stopni C.\n";
            }
        }
        static void Main(string[] args)
        {
            Temperatura temp1 = new Temperatura { Celcius = 26.6 };
            Console.Write(temp1.ToString());
            temp1.farenheit = 83.4;

            Console.Write("temp1 w farenheit wynosi: " + temp1.farenheit + "\n");
            Console.Write("temp1 w celciuszach wynosi: " + temp1.Celcius + "\n");
            Console.ReadKey(true);
        }
    }
}