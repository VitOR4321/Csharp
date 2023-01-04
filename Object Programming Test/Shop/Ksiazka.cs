using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_1_powtorkaObiektowosci.Sklep
{
    internal class Ksiazka : Produkt
    {
        private string rokWydania;
        public Ksiazka(string nazwa, string producent, int cena, int liczbaSztuk, string rokWydania) : base(nazwa, producent, cena, liczbaSztuk)
        {
            this.rokWydania = rokWydania;
        }

        public string getRokWydania()
        {
            return rokWydania;
        }

        public override string ToString()
        {
            return "Nazwa książki: " + getNazwa() + "\n" +
                   "Nazwa producenta: " + getPorducent() + "\n" +
                   "Rok wydania: " + getRokWydania() + "\n" +
                   "Cena: " + getCena() + "zł\n"
                   ;
        }
    }
}
