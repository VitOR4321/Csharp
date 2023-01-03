using System;
using System.Globalization;
namespace inst7_zad9
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = DateTime.Now;
            Console.WriteLine(string.Format(new CultureInfo("pl-PL"), "{0}", dt));
            Console.WriteLine(string.Format(new CultureInfo("en-GB"), "{0}", dt));
            Console.WriteLine(string.Format(new CultureInfo("en-US"), "{0}", dt));
            Console.ReadKey(true);
        }
    }
}
