using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_1_powtorkaObiektowosci.Sklep
{
    internal class Produkt
    {
        private string nazwa;
        private string producent;
        private int cena ;
        private int liczbaSztuk;

        public Produkt(string nazwa,string producent, int cena, int liczbaSztuk)
        {
            this.nazwa = nazwa;
            this.producent = producent;
            this.cena = cena;
            this.liczbaSztuk = liczbaSztuk;
        }

        public virtual string getNazwa()
        {
            return nazwa;
        }

        public virtual string getPorducent()
        {
            return producent;
        }

        public virtual int getCena()
        {
            return cena;
        }

        public virtual int getLiczbaSztuk()
        {
            return liczbaSztuk;
        }

        public virtual int getCenePoRabacie(int proc)
        {
            int cenaPo = (int)(cena * (1 - proc * 0.01));
            return cenaPo;
        }

        public void zmienStanMagazynu(int stan)
        {
            this.liczbaSztuk += stan;
        }

        public override string ToString()
        {
            return "Nazwa produktu: "+getNazwa()+"\n"+
                   "Nazwa producenta: " + getPorducent() + "\n" +
                   "Cena: " + getCena() + "zł\n"
                   ;
        }


    }
}
