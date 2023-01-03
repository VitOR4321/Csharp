using System;
using System.IO;

namespace zadanie_9
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Alarm07.wav";
            FileStream stream = File.Open(path, FileMode.Open); // tworzenie strumienia
            BinaryReader binary = new BinaryReader(stream);
            byte[] tablicaBitow = binary.ReadBytes(36);
            Console.WriteLine("Ilość kanałów: " + tablicaBitow[22]); // liczba kanałów
            Console.WriteLine("Częstotliwość próbkowania:  {0:X} kHz", tablicaBitow[24]); // częstotliwość 
            Console.WriteLine("Bity na próbke: " + tablicaBitow[34]); // rozdzileczośc próbkowania
            Console.ReadKey(true);
        }
    }
}
