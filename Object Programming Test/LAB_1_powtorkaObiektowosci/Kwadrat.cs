using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_1_powtorkaObiektowosci
{
    class Kwadrat : Czworokat
    {
        public Kwadrat(string opis, double bokA) : base(opis)
        {
            this.bokA = bokA;
        }

        public override double pole()
        {
            double pole = Math.Pow(bokA,2);
            if (pole <= 0)
            {
                Console.WriteLine("Prosze wpisać poprawne dane");
            }
            return pole;
        }

        public override double obwod()
        {
            double obwod = bokA*4;
            if (obwod <= 0)
            {
                Console.WriteLine("Prosze wpisać poprawne dane");
            }
            return obwod;
        }

        public override string ToString()
        {
            return "Opis figury: " +  opis + "\n" +
                    "Parametry Figury: "+bokA + "\n" +
                    "Pole figury: " + pole() + "\n" +
                    "Obwód figury: " + obwod() + "\n";
        }
    }
}
