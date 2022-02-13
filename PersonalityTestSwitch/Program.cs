using System;

namespace PersonalityTestSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajalt tema lemmikvärvi
            //kui kasutaja sisestab "punane", konsool kuvab "oled romantiline";
            //kui kasutaja sisestab "sinine", konsool kuvab "oled töökas";
            //kui kasutaja sisestab "roheline", konsool kuvab "oled looduse sõber";
            //kui kasutaja sisestab midagi muud, konsool kuvab "oled {UserColor} ükssarvik";


            Console.WriteLine("sisesta oma lemmikvärv");
            string UserColor = Console.ReadLine().ToLower();

            switch(UserColor)
            {
                case "punane": //if(UserColor == "punane")
                    Console.WriteLine("Oled romantiline.");
                    break;
                case "sinine":
                    Console.WriteLine("Oled töökas.");
                    break;
                case "roheline":
                    Console.WriteLine("Oled looduse sõber.");
                    break;
                default:
                    Console.WriteLine($"oled {UserColor} [ükssarvik");
                    break;

            }


            Console.WriteLine("Kena päeva!");


        }
         
    }
}
