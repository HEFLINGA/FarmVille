using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmVilleStep4
{
    // Horse class
    class Horse
    {
        // Methods for Horses   - Speak(), Eat(), Drink(), Service()       -

        public string name;

        public Horse() { }

        public Horse(string name)
        {
            this.name = name;
        }

        // Method for getting a Horse to speak!
        private string Speak(string name)
        {
            var speak = $"You hear the horse {name} whinny and neigh in the distance";

            return speak;
        }

        // Method for getting a Horses Service!
        private string Service(string name)
        {
            var service = $"{name} is a work horse! They haul stuff from place a to place b for you";

            return service;
        }

        public void HorseMenu(string horse1, string horse2, string horse3, string horse4)
        {
            var horseInput = "";

            Console.WriteLine("You arrived at the Horse corral! Press Enter to continue");
            Console.ReadLine();
            do
            {
                Console.Clear();
                Console.WriteLine("What would you like to do at the horse corral?");
                Console.WriteLine("1. Listen to the sound a horse makes?");
                Console.WriteLine("2. See what kind of Service a horse does?");
                Console.WriteLine("3. See what a horse eats?");
                Console.WriteLine("4. Have the horse drink some water?");
                Console.WriteLine("'exit' To exit to Main Menu");
                horseInput = Console.ReadLine().ToLower();

                if (horseInput != "exit")
                {
                    switch (horseInput)
                    {
                        case "1":
                            Console.WriteLine($"{new Horse().Speak(horse1)}");
                            Console.ReadLine();
                            break;
                        case "2":
                            throw new NotImplementedException("No Horse Service Method built yet");
                        case "3":
                            throw new NotImplementedException("No Horse Eating Method built yet");
                        case "4":
                            throw new NotImplementedException("No Horse Drinking Method built yet");
                    }
                }

            } while (horseInput != "exit");
        }
    }
}
