using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_1_powtorkaObiektowosci
{
    abstract class Figura
    {
        public string opis;
        public Figura(string opis)
        {
            this.opis = opis;
        }

        public virtual double pole()
        {
            double pole = 0;
            return pole;
        }

        public virtual double obwod()
        {
            double obwod = 0;
            return obwod;
        }

        public override string ToString()
        {
            return "Opis figury: "+opis+"\n"+
                   "Pole figury: " + pole() + "\n"+
                   "Obwód figury: " + obwod() + "\n";
        }

    }
}
