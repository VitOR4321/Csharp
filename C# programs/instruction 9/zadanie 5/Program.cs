using System;

namespace zadanie_5
{
    class Program
    {
        class temperatura
        {
            private double celcius;

            public double Celcius
            {
                set { celcius = value; }
                get { return celcius; }
            }
            
        }
        static void Main(string[] args)
        {
            temperatura temp1 = new temperatura();
            temperatura temp2 = new temperatura();
            try
            {
                Console.Write("podaj temp1\n");
                temp1.Celcius = double.Parse(Console.ReadLine());
                if(temp1.Celcius > -273)
                {
                    Console.Write("zmienna wprowadzona, kliknij enter\n");
                    Console.ReadKey(true);
                }
                else
                {
                    throw new ArgumentException();
                }
            }
            catch
            {
                Console.Write("obiekt temp1 jest za niski");
                Environment.Exit(0);
            }
            try
            {
                Console.Write("podaj temp2\n");
                temp2.Celcius = double.Parse(Console.ReadLine());
                if (temp2.Celcius > -273)
                {
                    Console.Write("zmienna wprowadzona, kliknij enter\n");
                    Console.ReadKey(true);
                }
                else
                {
                    throw new ArgumentException();
                }
            }
            catch
            {
                Console.Write("obiekt temp2 jest za niski");
                Environment.Exit(0);
            }
            Console.Write("temp1 wynosi: " + temp1.Celcius + "\n");
            Console.Write("temp2 wynosi: " + temp2.Celcius + "\n");

            double zmiana = temp1.Celcius;
            temp1.Celcius = temp2.Celcius;
            temp2.Celcius = zmiana;
            Console.Write("po zmianie\n");
            Console.Write("temp1 wynosi: " + temp1.Celcius + "\n");
            Console.Write("temp2 wynosi: " + temp2.Celcius + "\n");
        }
    }
}
