using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_1_powtorkaObiektowosci.Sklep
{
    internal class Pendrive : Produkt
    {
        private int pojemnosc;
        public Pendrive(string nazwa, string producent, int cena, int liczbaSztuk, int pojemnosc) : base(nazwa, producent, cena, liczbaSztuk)
        {
            this.pojemnosc = pojemnosc;
        }

        public int getSize()
        {
            return pojemnosc;
        }


        public override string ToString()
        {
            return "Nazwa pendive'a: " + getNazwa() + "\n" +
                   "Nazwa producenta: " + getPorducent() + "\n" +
                   "Pojemność: " + getSize() + "GB\n" +
                   "Cena: " + getCena() + "zł\n"
                   ;
        }
    }
}
