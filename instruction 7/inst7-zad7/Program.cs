using System;

namespace inst7_zad7
{ 
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prosze wprowadzić ciag znaków:");
            string x = " ";
            x = x + Console.ReadLine();
            int[] tab = new int[x.Length + 2];
            tab[x.Length] = 128;
            tab[x.Length + 1] = 128;
            bool przecinek = false;
            bool przerwa = false;
            bool e = false;
            bool minus = false;
            for (int i = 0; i < x.Length; i++)
            {
                tab[i] = Convert.ToInt32(x[i]);
            }
            for (int i = 0; i < x.Length; i++)
            {
                if ((tab[i] >= 48) && (tab[i] <= 57))
                {
                    Console.Write(x[i]);
                    przerwa = false;
                }
                else if (((tab[i] == 44) || (tab[i] == 46)) && (tab[i + 1] >= 48) && (tab[i + 1] <= 57) && (tab[i - 1] >= 48) && (tab[i - 1] <= 57) && (przecinek == false))
                {
                    Console.Write(x[i]);
                    przerwa = false;
                    przecinek = true;

                }
                else if ((tab[i] == 101) && (tab[i + 1] != 101) && (tab[i - 1] != 101) && (e == false))
                {
                    Console.Write(x[i]);
                    przerwa = false;
                    e = true;
                }
                else if ((tab[i] == 45) && (tab[i + 1] != 45) && (tab[i - 1] != 45) && (minus == false))
                {
                    Console.Write(x[i]);
                    przerwa = false;
                    minus = true;
                }
                else if (tab[i] == 32)
                {
                    Console.Write(0);
                    przerwa = false;
                }
                else if (przerwa == false)
                {
                    Console.WriteLine(x[i]);
                    przecinek = false;
                    przerwa = true;
                    e = false;
                    minus = false;

                }
            }
            Console.ReadKey(true);
        }
    }
}