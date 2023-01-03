using System;

namespace zadanie_3
{
    class Program
    {
        class Temperatura
        {
            private double celcious;

            public double Celcious
            {
                set { celcious = value; }
                get { return celcious; }
            }
        }
        static void Main(string[] args)
        {
            Temperatura Temp1 = new Temperatura();
            Temperatura Temp2 = new Temperatura();

            Temp1.Celcious = 36.6;
            Temp2.Celcious = 34.7;

            Console.Write("Temp1 wynosi: " + Temp1.Celcious + "\n");
            Console.Write("Temp2 wynosi: " + Temp2.Celcious + "\n");

            double zmiana = Temp1.Celcious;
            Temp1.Celcious = Temp2.Celcious;
            Temp2.Celcious = zmiana;

            Console.Write("Po zmianie\n");
            Console.Write("Temp1 wynosi: " + Temp1.Celcious + "\n");
            Console.Write("Temp2 wynosi: " + Temp2.Celcious + "\n");
            Console.ReadKey(true);
        }
    }
}