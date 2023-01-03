using System;
using System.Diagnostics;

namespace Zadanie_10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Podaj 'pause' lub 'tree C:\' dla testu (/C od razu po wykonaniu polecenia zamyka CMD)
            while (true)
            {
                Console.Write("Podaj polecenie: ");
                string strCmdCommand = Console.ReadLine();
                string strCmdText = "/C " + strCmdCommand;
                Process.Start("CMD.exe", strCmdText);
            }
        }
    }
}
