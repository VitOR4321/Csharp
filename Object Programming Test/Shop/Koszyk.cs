using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_1_powtorkaObiektowosci.Sklep
{
      public class Koszyk
     {
        class PozycjaKoszyka{
            public Produkt produkt;
            public int ilosc;
            public int wartoscProzycji()
            {
                return produkt.getCena() * ilosc;
            }
            public string podajNazwe()
            {
                return produkt.getNazwa();
            }

            public void podajIlosc(int ilosc)
            {
                this.ilosc = ilosc;
            }
            public  void podajProdukt(Produkt produkt)
            {
                this.produkt = produkt;
            }
        }

        List<PozycjaKoszyka> koszyk = new List<PozycjaKoszyka>();

        public void doKoszyka(PozycjaKoszyka i)
        {
            koszyk.Add(i);
        }

        public void pokazKoszyk()
        {
            for(int i = 0; i < koszyk.Count; i++)
            {
                Console.WriteLine(koszyk[i].produkt.getNazwa() + ", ilosc: " + koszyk[i].ilosc);
            }
        }

        public int wartoscKoszyka()
        {
            int suma = 0;
            for(int i=0; i < koszyk.Count; i++)
            {
                suma += koszyk[i].produkt.getCena() * koszyk[i].ilosc;
            }
            return suma;
        }

         public int wartoscKoszykaPoRabacie()
        {
            int suma = 0;
            for (int i = 0; i < koszyk.Count; i++)
            {
                suma += koszyk[i].produkt.getCenePoRabacie(10) * koszyk[i].ilosc;
            }
            return suma;
        }
    }
}
