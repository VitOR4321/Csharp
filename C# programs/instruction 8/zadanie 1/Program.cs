using System;
using System.IO;
using System.Text;

namespace zadanie_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\User\Desktop\plik.txt";
            try
            {
                if (File.Exists(path))
                {
                    File.Delete(path);
                }
                using(FileStream fs=File.Create(path))
                {
                    Byte[] title = new UTF8Encoding(true).GetBytes("Nazwa pliku\n");
                    fs.Write(title, 0, title.Length);
                    byte[] autor = new UTF8Encoding(true).GetBytes("Autor pliku\n");
                    fs.Write(autor, 0, autor.Length);
                }
                using (StreamReader sr = File.OpenText(path))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Console.ReadKey(true);
        }
    }
}
