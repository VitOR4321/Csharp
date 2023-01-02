using System;


namespace inst7_zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            char x;
            int liczba = 0;
            int x_int = 0;
            Console.WriteLine("Wprowadź ciąg znaków");
            string y = Console.ReadLine();
            for(int i=0;i<y.Length;i++)
            {
                x = y[i];
                if(char.IsDigit(x))
                {
                    x_int = Convert.ToInt32(x);
                    x_int = x_int - 48;
                    if(liczba>0)
                    {
                        liczba = (liczba * 10) + x_int;
                    }
                    else
                    {
                        liczba = x_int;
                    }
                }
                if((char.IsDigit(x)==false || i==y.Length-1) && liczba !=0)
                {
                    Console.WriteLine("liczba nr {0}", liczba);
                    liczba = 0;
                }
                if ((char.IsDigit(x) == true) && x_int==0)
                {
                    Console.WriteLine("liczba nr {0}", liczba);
                    liczba = 0;
                }
            }
            Console.ReadKey(true);
        }
    }
}
