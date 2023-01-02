using System;
using System.IO;
using System.Text;

namespace zadanie_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\User\Desktop\plik.txt";
            try
            {
                using (StreamReader sr = File.OpenText(@path))//musi być tekst w pliku i sworzony plik
                {
                    string linia ;
                    string cyfry="";
                    while ((linia = sr.ReadLine()) != null)
                    {
                        for(int i=0;i<linia.Length;i++)
                        {
                            if(char.IsDigit(linia[i]))
                            {
                                cyfry += linia[i];
                            }
                        }
                        if(cyfry.Length>0)
                        {
                            Console.Write(Math.Pow(int.Parse(cyfry), 2));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
