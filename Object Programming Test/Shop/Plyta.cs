using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_1_powtorkaObiektowosci.Sklep
{
    internal class Plyta : Produkt
    {
        private int liczbaUtworow;
        public Plyta(string nazwa, string producent, int cena, int liczbaSztuk, int liczbaUtworow) : base(nazwa, producent, cena, liczbaSztuk)
        {
            this.liczbaUtworow = liczbaUtworow;
        }

        public int getLiczbaUtworow()
        {
            return liczbaUtworow;
        }

        public override string ToString()
        {
            return "Nazwa płyty: " + getNazwa() + "\n" +
                   "Nazwa wykonawcy: " + getPorducent() + "\n" +
                   "Liczba utworów: " + getLiczbaUtworow() + " utworów\n" +
                   "Cena: " + getCena() + "zł\n"
                   ;
        }
    }
}
