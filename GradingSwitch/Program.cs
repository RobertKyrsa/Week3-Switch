using System;

namespace GradingSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib, mis hinde kasutaja sai
            //kui kasutaja sai "A", konsool kuvab "Suurepärane!"
            //kui tulemus on "B", konsool kuvab "Väga Hea!"
            //kui tulemus on "C", konsool kuvab "Hea!"
            //kui tulemus on "D", konsool kuvab "Rahuldav"
            //kui tulemus on "E", konsool kuvab "Kasin"
            //kui tulemus on "F", konsool kuvab "Puudulik"
            //kui kasutaja sisestab midagi muud, siis konsool kuvab "vale väärtus"

            Console.WriteLine("Sisesta oma tulemus:");

            //char - character
            char UserResult = Convert.ToChar(Console.ReadLine().ToUpper());

            switch (UserResult)
            {
                case 'A': 
                    Console.WriteLine("Suurepärane!");
                    break;
                case 'B': 
                    Console.WriteLine("Väga Hea!");
                    break;
                case 'C': 
                    Console.WriteLine("Hea!");
                    break;
                case 'D': 
                    Console.WriteLine("Rahuldav");
                    break;
                case 'E': 
                    Console.WriteLine("Kasin");
                    break;
                case 'F': 
                    Console.WriteLine("Puudulik");
                    break;
                default:
                    Console.WriteLine($"Vale väärtus.");
                    break;

            }
        }
    }
}
