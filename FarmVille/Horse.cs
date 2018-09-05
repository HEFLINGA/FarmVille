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
            var speak = $"You hear the horse {name} whinny and neigh in the distance. Press Enter to continue";

            return speak;
        }

        // Method for getting a Horses Service!
        private string Service(string name)
        {
            var service = $"{name} is a work horse! They haul stuff from place a to place b for you. Press Enter to continue";

            return service;
        }

        // Method for getting what a horse eats!
        private string Eat(string name)
        {
            var eat = $"Your horses eat Hay!! {name} eats a little to much of it.. Press Enter to continue";

            return eat;
        }

        // Method for horses drinking water
        private string Drink(string name)
        {
            var drink = $"Your horse {name} is drinking some water at the trough! Press Enter to continue";

            return drink;
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
                            Console.WriteLine($"{new Horse().Service(horse2)}");
                            Console.ReadLine();
                            break;
                        case "3":
                            Console.WriteLine($"{new Horse().Eat(horse3)}");
                            Console.ReadLine();
                            break;
                        case "4":
                            Console.WriteLine($"{new Horse().Drink(horse4)}");
                            Console.ReadLine();
                            break;
                    }
                }

            } while (horseInput != "exit");
        }
    }
}
