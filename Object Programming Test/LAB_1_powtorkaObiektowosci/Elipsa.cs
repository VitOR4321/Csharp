using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_1_powtorkaObiektowosci
{
    internal class Elipsa : Figura
    {
        public double przekatnaA;
        public double przekatnaB;
        public Elipsa(string opis, double przekatnaA , double przekatnaB) : base(opis)
        {
            this.przekatnaB = przekatnaB;
            this.przekatnaA = przekatnaA;
        }

        public override double pole()
        {
            double pole = Math.PI *(przekatnaA/2)*(przekatnaB/2);
            if (pole <= 0)
            {
                Console.WriteLine("Prosze wpisać poprawne dane");
            }
            return pole;
        }

        public override double obwod()
        {
            double a = (przekatnaA / 2);
            double b = (przekatnaB / 2);
            double obwod = Math.PI*((3/2)*(a+b)-Math.Sqrt(a*b));

            return obwod;
        }
        public override string ToString()
        {
            return "Opis figury: " + opis + "\n" +
                    "Parametry Figury: " + przekatnaA + ", " + przekatnaB + "\n" +
                    "Pole figury: " + pole() + "\n" +
                    "Obwód figury: " + obwod() + "\n";
        }
    }
}
