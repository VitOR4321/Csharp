using System;
using System.Globalization;

namespace inst7_zad8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Format(new CultureInfo("pl-PL"), "{0:C}", 1234.5678));
            Console.WriteLine(string.Format(new CultureInfo("en-GB"), "{0:C}", 1234.5678));
            Console.WriteLine(string.Format(new CultureInfo("en-US"), "{0:C}", 1234.5678));
            Console.ReadKey(true);
        }
    }
}
