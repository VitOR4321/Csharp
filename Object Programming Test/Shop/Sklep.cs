using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LAB_1_powtorkaObiektowosci.Sklep
{
    public class Sklep
    {
        /*
     static List<Produkt> listaProduktow = new List<Produkt>();

      static int IleWartosci()
      {
          int suma = 0;
          for (int i = 0; i < listaProduktow.Count(); i++)
              suma += listaProduktow[i].getLiczbaSztuk() * listaProduktow[i].getCena();
          return suma;
      }


      static void IleProduktow()
      {
          for (int i = 0; i < listaProduktow.Count(); i++)
              Console.WriteLine((i + 1) +". " +listaProduktow[i].getNazwa()+ " Ilość: "+ listaProduktow[i].getLiczbaSztuk());
      }


      static void Main(string[] args)
      {
          listaProduktow.Add(new Ksiazka("Fella","Unia", 4, 6,"2012.05.24"));
          listaProduktow.Add(new Ksiazka("Akama", "Unia", 3, 3, "2017.04.14"));
          listaProduktow.Add(new Ksiazka("Bitka", "Punia", 7, 2, "2018.08.28"));
          listaProduktow.Add(new Ksiazka("Yea", "Niunia", 6, 6, "2022.12.22"));

          listaProduktow.Add(new Plyta("Mama", "Pląs", 56, 5, 6));
          listaProduktow.Add(new Plyta("Papa", "Wąs", 35, 6, 7));
          listaProduktow.Add(new Plyta("Siata", "Sztos", 76, 2, 9));

          listaProduktow.Add(new Pendrive("Modern", "Lala", 24, 1, 16));
          listaProduktow.Add(new Pendrive("Fast", "Fala", 30, 3, 32));
          listaProduktow.Add(new Pendrive("Blast", "Fala", 56, 2, 128));


          for (int i = 0; i < listaProduktow.LongCount(); i++)
          {
              Console.WriteLine(listaProduktow[i]);
          }

          Console.WriteLine("Całkowita warotść produktów w sklepie: "+ IleWartosci());

          Koszyk koszyk = new Koszyk();
          int pozycja = 0;
          int sztuki = 0 ;
          bool koniec = false;
          string zamowienie;
          while (true)
          {
              Console.WriteLine("Wpisz numer produktu, który dodajesz do koszyka. \r Wpisz zero aby zakończyć działanie programu.");
              IleProduktow();
              while(true)
              {
                 zamowienie=Console.ReadLine();
                  if (zamowienie == "0")
                  {
                      koniec = true;
                      break;
                  }
                  if(Regex.IsMatch(zamowienie, @"^\d+$"))
                  {
                      if (int.Parse(zamowienie)>0 && int.Parse(zamowienie)<listaProduktow.Count+1)
                      {
                          pozycja = int.Parse(zamowienie);
                          break;
                      }
                      else
                      {
                          Console.WriteLine("Podano zły numer produktu.");
                      }
                  }
                  else
                  {
                      Console.WriteLine("Podano zły format danych");
                  }
              }
              if (koniec)
                  break;
              Console.WriteLine("Podaj ilość sztuk produktu.");
              while (true)
              {
                  zamowienie = Console.ReadLine();
                  if(Regex.IsMatch(zamowienie, @"^\d+$"))
                  {
                      if(int.Parse(zamowienie)>0 && int.Parse(zamowienie) <= listaProduktow[pozycja-1].getLiczbaSztuk())
                      {
                          sztuki = int.Parse(zamowienie);
                          break;
                      }
                      else
                      {
                          Console.WriteLine("Podano zła liczbe sztuk produktu w magazynie.");
                      }
                  }
                  else
                  {
                      Console.WriteLine("Podano zły format danych");
                  }
              }
              Koszyk.PozycjaKoszyka pozycjaKoszyka = new PozycjaKoszyka();
              pozycjaKoszyka.podajProdukt(listaProduktow[pozycja - 1]);
              listaProduktow[pozycja - 1].zmienStanMagazynu(-sztuki);
              pozycjaKoszyka.podajIlosc(sztuki);
              koszyk.doKoszyka(pozycjaKoszyka);
          }
          koszyk.pokazKoszyk();
          Console.WriteLine("Wartość koszyka wynosi: "+ koszyk.wartoscKoszyka()+"zł");
          if(koszyk.wartoscKoszyka()>300)
          {
              Console.WriteLine("Wartość zawarotści koszyka z rabatem 10%: " + koszyk.wartoscKoszykaPoRabacie() + "zł.");
          }

      }
         */

    }

}
