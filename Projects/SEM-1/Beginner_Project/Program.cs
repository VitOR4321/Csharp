using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Projekt_na_PP_V2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Początek programu 
            Console.WriteLine("Witam w programie, który liczby potrzebą ilość tynku dekoracyjnego na ściany,");
            Console.WriteLine("oraz oblicza cenę tego tynku.");
            Console.WriteLine("Cena kilogramu tynku dekoracyjnego o warstwie 1 milimetr wynosi 8 zł za metr kwadratowy.");
            Console.WriteLine("Proszę podać rodzaj domu, są dostępne 2 rodzaje: ");
            Console.WriteLine("1-Sześcienny");
            Console.WriteLine("2-Prostopadłościan");
            // zmienne urzyte w funckji Main
            double r,a,b,h,ad,hd;//r-rodzaj domu, a-długość krótrzej ściany, b-długość dłuższej ściany, h-wysokość ścian, ad-długość drzwi, hd-wysokość drzwi
            r = Int32.Parse(Console.ReadLine());
            // operacja wybierająca rozmiar domu
            if(r == 1)// ps-pole ścian sześcianu
            {
                // dane dotyczące pola ścian
                Console.Write("Wybrano dom Sześcienny\n");
                Console.Write("------------------------------------\n");
                Console.Write("Wymiar ścian:\n");
                Console.Write("Proszę podać długość ścian w metrach: \n");
                a = double.Parse(Console.ReadLine());
                double ps = pole_sześcianu(a);
                Console.Write("Pole ścian wynosi: {0:#.##} m^2. \n", ps);
                // dane dotyczące pola drzwi wejściowych
                double wd =0;
                Console.Write("------------------------------------\n");
                Console.Write("Wymiar drzwi wejściowych:\n");
                Console.Write("Proszę podać długość drzwi w metrach: \n");
                ad = double.Parse(Console.ReadLine());
                Console.Write("Proszę podać wysokość drzwi w metrach: \n");
                hd = double.Parse(Console.ReadLine());
                // sprawdzenie wymiarów drzwi wejściowych
                if (ad < a && hd < a)
                {
                     wd = wymiar_drzwi_sześcian(ad, hd);
                }
                else
                {
                    Console.Write("wymiary drzwi są niepoprawne.\n");
                    Console.Write("Proszę uruchomić program od nowa.\n");
                    Console.ReadKey(true);
                    System.Environment.Exit(0);
                }
                Console.Write("Pole drzwi wejściowych wynosi: {0:#.##} m^2\n", wd);
                // warstwa tynku dekoracyjnego
                double gt;//gt-grubość tynku
                Console.Write("------------------------------------\n");
                Console.Write("Warstwa tynku:\n");
                Console.Write("Proszę podać warstwę tynku w milimetrach: \n");
                gt = double.Parse(Console.ReadLine());
                Console.Write("Grubość tynku: {0} mm. \n", gt);
                // pola okien
                double ile,o;//ile-ile rodzajów okien, o-pole wszystkich okien
                Console.Write("------------------------------------\n");
                Console.Write("Pola okien:\n");
                Console.Write("Proszę podać ilość wyszystkich wymiarów okien:\n");
                ile = double.Parse(Console.ReadLine());
                o = pola_okien(ile);
                // sprawdzenie czy pole okien nie jest większe niż pole ścian
                if (o < ps)
                {
                    Console.Write("Pola okien wynosi: {0:#.##} m^2\n", o);
                }
                else
                {
                    Console.Write("Pole wszystkich okien wynosi więcej niż pole ścian.\n");
                    Console.Write("Proszę uruchomić program od nowa.\n");
                    Console.ReadKey(true);
                    System.Environment.Exit(0);
                }
                // pole do otynkowania
                Console.Write("------------------------------------\n");
                double pc;//pc-pole całkowite ścian
                pc = (ps - o) - wd;
                Console.Write("Pole ścian do otynkowania wynosi: {0:#.##} m^2\n", pc);
                //ilość tynku
                Console.Write("------------------------------------\n");
                double ilt;// ilt-ile tynku potrzeba 
                ilt = pc * gt;
                Console.Write("Potrzebna ilość tynku wynosi: {0:#.##} kg\n", ilt);
                //cena tynku
                Console.Write("------------------------------------\n");
                double ct;//ct-całkowity koszt
                ct = ilt * 8;
                Console.Write("Cena tynku: wynosi: {0:#.##} zł\n", ct);
            }
            else if (r == 2)//pp-pole ścian prostopadłościanu
            {
                // dane dotyczące pola ścian
                Console.Write("Wybrano dom Prostopadłościenny\n");
                Console.Write("------------------------------------\n");
                Console.Write("Wymiar ścian:\n");
                Console.Write("Proszę podać długość krótrzych ścian w metrach: \n");
                a = double.Parse(Console.ReadLine());
                Console.Write("Proszę podać długość dłuższych ścian w metrach: \n");
                b = double.Parse(Console.ReadLine());
                Console.Write("Proszę podać wysokość ścian w metrach: \n");
                h = double.Parse(Console.ReadLine());
                double pp = pole_prostopadłościanu(a, b, h);
                Console.Write("Pole ścian wynosi: {0:#.##} m^2. \n", pp);
                // dane dotyczące pola drzwi wejściowych
                double wd = 0;
                Console.Write("------------------------------------\n");
                Console.Write("Wymiar drzwi wejściowych:\n");
                Console.Write("Proszę podać długość drzwi w metrach: \n");
                ad = double.Parse(Console.ReadLine());
                Console.Write("Proszę podać wysokość drzwi w metrach: \n");
                hd = double.Parse(Console.ReadLine());
                // sprawdzenie wymiarów drzwi wejściowych
                if (ad < a && hd < h && ad<b)
                {
                    wd = wymiar_drzwi_prostopadłościan(ad, hd);
                    Console.Write("Pole drzwi wejściowych wynosi: {0:#.##} m^2\n", wd);
                }
                else
                {
                    Console.Write("wymiary drzwi są niepoprawne.\n");
                    Console.Write("Proszę uruchomić program od nowa.\n");
                    Console.ReadKey(true);
                    System.Environment.Exit(0);
                }
                // warstwa tynku dekoracyjnego
                double gt;//gt-grubość tynku
                Console.Write("------------------------------------\n");
                Console.Write("Warstwa tynku:\n");
                Console.Write("Proszę podać warstwę tynku w milimetrach: \n");
                gt = double.Parse(Console.ReadLine());
                Console.Write("Grubość tynku: {0} mm. \n", gt);
                // pola okien
                double ile,o;//ile-ile rodzajów okien, o-pole wszystkich okien
                Console.Write("------------------------------------\n");
                Console.Write("Pola okien:\n");
                Console.Write("Proszę podać ilość wszytkich wymiarów okien:\n");
                ile = double.Parse(Console.ReadLine());
                o = pola_okien(ile);
                // sprawdzenie czy pole okien nie jest większe niż pole ścian
                if (o < pp)
                {
                    Console.Write("Pola okien wynosi: {0:#.##} m^2\n", o);
                }
                else
                {
                    Console.Write("Pole wszystkich okien wynosi więcej niż pole ścian.\n");
                    Console.Write("Proszę zacząć od nowa.\n");
                    Console.ReadKey(true);
                    System.Environment.Exit(0);
                }
                // pole do otynkowania
                Console.Write("------------------------------------\n");
                double pc;//pc-pole całkowite ścian
                pc = (pp - o) - wd;
                Console.Write("Pole ścian do otynkowania wynosi: {0:#.##} m^2\n", pc);
                //ilość tynku
                Console.Write("------------------------------------\n");
                double ilt;// ilt-ile tynku potrzeba 
                ilt = pc * gt;
                Console.Write("Potrzebna ilość tynku: wynosi: {0:#.##} kg\n", ilt);
                //cena tynku
                Console.Write("------------------------------------\n");
                double ct;
                ct = ilt * 8;//ct-całkowity koszt
                Console.Write("Cena tynku: wynosi: {0:#.##} zł\n", ct);
            }
            else
            {
                Console.Write("Podano złą cyfre.\n");
                
            }
            Console.ReadKey(true);
        }
        static double pole_sześcianu(double a)//funkcja licząca pole sześciennego domu
        {
            double p;
            p = (a * a) * 4;
            return p;
        }
        static double pole_prostopadłościanu(double a, double b, double h)//funkcja licząca pole prostopadłościennego  domu
        {
            double p;
            p = ((a * h) * 2)+((b*h)*2);
            return p;
        }
         static double wymiar_drzwi_sześcian(double ad, double hd)//funkcja odpowiedzialna za wyliczenie pola drzwi
        {
            double pd;
            pd = ad * hd;
            return pd;
        }
         static double wymiar_drzwi_prostopadłościan(double ad, double hd)//funkcja odpowiedzialna za wyliczenie pola drzwi
        {
            double pd;
            pd = ad * hd;
            return pd;
        }
        static double pola_okien(double ile)// funkcja opowiedzialna za wyliczenie pola okien
        {
            double i,ho,ao,po,ilo,spo=0;
            for(i=1;i<=ile;i++)
            {
                
                Console.Write("proszę podać wysokość okna nr {0}: ",i);
                ho = double.Parse(Console.ReadLine());
                Console.Write("proszę podać długość okna nr {0}: ",i);
                ao = double.Parse(Console.ReadLine());
                Console.Write("proszę podać ilość okien nr {0}: ", i);
                ilo = double.Parse(Console.ReadLine());
                po = (ho * ao)*ilo;
                spo += po;
            }
            return spo;
        }
    }
}