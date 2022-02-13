using System;

namespace CatsAndDogs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Are you more like a cat or a dog?");
            string UserChoice = Console.ReadLine().ToLower();

            if (UserChoice == "cat")
            {
                Console.WriteLine("You ara a home-lover.");
            }
            else if (UserChoice == "dog")
            {
                Console.WriteLine("You ara a partygoer.");
            }
            else
            {
                Console.WriteLine($"You are a {UserChoice} friend");
            }

            
        }
    }
}
