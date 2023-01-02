using System;
using System.IO;
using System.Text;

namespace zadanie_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\User\Desktop\plik";
            try
            {
                if (File.Exists(path))
                {
                    File.Delete(path);
                }
                using (FileStream fs = File.Create(path))
                {
                    byte[] tytuł = Encoding.Unicode.GetBytes("tytul pliku\n");//Unicode- UTF16
                    fs.Write(tytuł, 0, tytuł.Length);
                    /*
                     UTF 8
                     Byte[] title = new UTF8Encoding(true).GetBytes("Nazwa pliku\n");
                    fs.Write(title, 0, title.Length);
                    UTF 32
                    Byte[] title = new UTF32Encoding(false,true,true).GetBytes("Nazwa pliku\n");
                     */
                }
                using (StreamReader sr = File.OpenText(path))
                {
                    string s = " ";
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
        }
    }
}
