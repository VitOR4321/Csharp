using System;

namespace inst7_zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            string a ;
            Console.WriteLine("Podaj ciąg znaków");
            a = Console.ReadLine();
            char[] ch = new char[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                ch[i] = a[i];
            }
            foreach (char c in ch)
            {
                if(char.IsDigit(c))
                {
                    Console.WriteLine(c);
                }
                    }
            Console.ReadKey(true);
        }
    }
}
