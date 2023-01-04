using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_1_powtorkaObiektowosci
{
    internal class TrojkatProstokatny : Trojkat
    {

        public TrojkatProstokatny(string opis, double bokA, double bokB) : base(opis)
        {
            this.bokA = bokA;
            this.bokB = bokB;
        }

        public override double pole()
        {
            double pole =(bokA * bokB)/2;
            if (pole <= 0)
            {
                Console.WriteLine("Prosze wpisać poprawne dane");
            }
            return pole;
        }

        public override double obwod()
        {
            double bokC = Math.Sqrt(Math.Pow(bokA,2)+Math.Pow(bokB,2));
            double obwod= bokA +bokB+ bokC;
            if (obwod <= 0)
            {
                Console.WriteLine("Prosze wpisać poprawne dane");
            }
            return obwod;
        }
        public override string ToString()
        {
            return "Opis figury: " + opis + "\n" +
                    "Parametry Figury: " + bokA +", " + bokB + "\n" +
                    "Pole figury: " + pole() + "\n" +
                    "Obwód figury: " + obwod() + "\n";
        }
    }
}
