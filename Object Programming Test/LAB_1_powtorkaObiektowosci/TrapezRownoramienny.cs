using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_1_powtorkaObiektowosci
{
    internal class TrapezRownoramienny : Czworokat
    {
        public double wysokosc;

        public TrapezRownoramienny(string opis, double bokA, double bokB, double wysokosc) : base(opis)
        {
            this.bokA = bokA;
            this.bokB = bokB;
            this.wysokosc = wysokosc;
        }

        public override double pole()
        {
            double pole = (bokA + bokB) / wysokosc * 2;
            if (pole <= 0)
            {
                Console.WriteLine("Prosze wpisać poprawne dane");
            }
            return pole;
        }

        public override double obwod()
        {
            double y = bokB - bokA;
            double bokC = Math.Sqrt(Math.Pow(wysokosc, 2) + Math.Pow(y, 2));
            double obwod = bokA + bokB + bokC * 2;
            if (obwod <= 0)
            {
                Console.WriteLine("Prosze wpisać poprawne dane");
            }
            return obwod;
        }

        public override string ToString()
        {
            return "Opis figury: " + opis + "\n" +
                    "Parametry Figury: " + bokA +", "+ bokB + ", " + wysokosc + "\n" +
                    "Pole figury: " + pole() + "\n" +
                    "Obwód figury: " + obwod() + "\n";
        }
    }
}
