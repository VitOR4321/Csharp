using System;
using System.IO;
using System.Text;

namespace zadanie_6
{
    class Program
    {
        static void Main(string[] args)
        {
            nazwa:
            Console.Write("proszę podać nazwę pliku\n");
            string nazwa=Console.ReadLine();
            if(!nazwa.EndsWith(".txt"))
            {
                nazwa += ".txt";
            }
            string path = @"C:\Users\User\Desktop\";
            string file_path = Path.Combine(path, nazwa);
           /*
                if (!File.Exists(file_path))
                {
                    Console.Write("sory ale nie");
                    goto nazwa;
                }
            /*
            using (FileStream fs = File.Create(file_path))
            {
                byte[] tekst = Encoding.Unicode.GetBytes("ala ma 4 koty\n");//Unicode- UTF16
                fs.Write(tekst, 0, tekst.Length);
            }
            */
            try { 
                    using (StreamReader sr = File.OpenText(file_path))//musi być tekst w pliku i sworzony plik
                {
                    string linia;
                    string cyfry = "";
                    while ((linia = sr.ReadLine()) != null)
                    {
                        for (int i = 0; i < linia.Length; i++)
                        {
                            if (char.IsDigit(linia[i]))
                            {
                                cyfry += linia[i];
                            }
                        }
                        if (cyfry.Length > 0)
                        {
                            Console.Write(Math.Pow(int.Parse(cyfry), 2)+"\n");
                        }
                        cyfry = "";
                    }
                }
            }
            catch (System.IO.FileNotFoundException)
            {
                Console.WriteLine("ej no kurwa co ty");
                goto nazwa;
            }
        }
    }
}