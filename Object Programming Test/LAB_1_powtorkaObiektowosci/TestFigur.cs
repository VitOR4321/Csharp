using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_1_powtorkaObiektowosci
{
    internal class TestFigur
    {
        
        static void Main(string[] args)
        {
            List<Figura> fig = new List<Figura>();

            fig.Add(new Kwadrat("Kwadrat",4));
            fig.Add(new Prostokat("Prostokąt", 6, 4));
            fig.Add(new TrapezRownoramienny("Trapez Równoramienny", 6, 4, 8));

            for(int i=0; i<fig.LongCount();i++)
            {
                Console.WriteLine(fig[i]);
            }
            string figura="";
            while (figura != "0") {
                Console.Write("Proszę wprowadzic figure i dane po spacji: ");
                figura = Console.ReadLine();
                string[] dane = figura.Split(" ");
                if (dane[0] == "k")
                {
                    int bokA = int.Parse(dane[1]);
                    fig.Add(new Kwadrat("Kwadrat", bokA));
                }
                else if(dane[0] == "p")
                {
                    int bokA = int.Parse(dane[1]);
                    int bokB = int.Parse(dane[2]);
                    fig.Add(new Prostokat("Prostokąt", bokA, bokB));
                }
                else if (dane[0] == "t")
                {
                    int bokA = int.Parse(dane[1]);
                    int bokB = int.Parse(dane[2]);
                    int W = int.Parse(dane[3]);
                    fig.Add(new TrapezRownoramienny("Trapez Rownoramienny", bokA, bokB, W));
                }
                else if (dane[0] == "tr")
                {
                    int bokA = int.Parse(dane[1]);
                    fig.Add(new TrojkatRownoboczny("Trójkat Równoboczny", bokA));
                }
                else if (dane[0] == "tp")
                {
                    int bokA = int.Parse(dane[1]);
                    int bokB = int.Parse(dane[2]);
                    fig.Add(new TrojkatProstokatny("Trójkat Prostokątny", bokA, bokB));
                }
                else if (dane[0] == "e")
                {
                    int przekA = int.Parse(dane[1]);
                    int przekB = int.Parse(dane[2]);
                    fig.Add(new Elipsa("Elipsa", przekA, przekB));
                }
                Console.ReadKey();
            }
            for (int i = 0; i < fig.LongCount(); i++)
            {
                Console.WriteLine(fig[i]);
            }
        }
        

    }
}
