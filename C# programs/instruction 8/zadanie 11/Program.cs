using System;
using System.IO;

namespace zadanie_11
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            bool command_exit = false;
            while (!command_exit)
            {
                Console.WriteLine("Jesteś tu ===>   " + path);
                Console.WriteLine("Wpisz komendę (dir/cd/type/exit)");
                string command = Console.ReadLine();
                if (command == "dir")
                {
                    string[] file_list = Directory.GetFiles(path);
                    string[] dir_list = Directory.GetDirectories(path);
                    foreach (string dir in dir_list)
                    {
                        Console.WriteLine(dir);
                    }
                    foreach (string file in file_list)
                    {
                        Console.WriteLine(file);
                    }
                }
                else if (command == "cd")
                {
                    Console.WriteLine("Zapodaj lokalizacje");
                    string cd = Console.ReadLine();
                    if (Directory.Exists(cd))
                    {
                        path = cd;
                    }
                    else
                    {
                        Console.WriteLine("Błąd: brak lub zła ścieżka");
                    }
                }
                else if (command == "type")
                {
                    // 11
                    try
                    {
                        string type = Console.ReadLine();
                        using (StreamReader reader = File.OpenText(path + @"\" + type))
                        {
                            string text;
                            while ((text = reader.ReadLine()) != null)
                            {
                                Console.WriteLine(text);
                            }
                        }
                    }
                    catch (FileNotFoundException)
                    {
                        Console.WriteLine("Błąd: plik o takiej nazwie nie istnieje");
                    }
                    catch (DirectoryNotFoundException)
                    {
                        Console.WriteLine("Błąd: nie ma nazwy");
                    }
                }
                else if (command == "exit")
                {
                    command_exit = true;
                }
            }
        }
    }
}