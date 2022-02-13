using System;

namespace GradingIF
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


            if (UserResult == 'A')
            {
                Console.WriteLine("Suurepärane!");
            }
            else if (UserResult == 'B')
            {
                Console.WriteLine("Väga Hea!");
            }
            else if (UserResult == 'C')
            {
                Console.WriteLine("Hea!");
            }
            else if (UserResult == 'D')
            {
                Console.WriteLine("Rahuldav");
            }
            else if (UserResult == 'E')
            {
                Console.WriteLine("Kasin");
            }
            else if (UserResult == 'F')
            {
                Console.WriteLine("Puudulik");
            }
            else
            {
                Console.WriteLine($"Vale väärtus.");

            }

           
        }
    }
}
