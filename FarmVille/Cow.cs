using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmVilleStep4
{
    // Cow Class
    class Cow
    {
        // Methods for Cows     - Speak(), Eat(), Drink(), Service()       -

        public string name;

        public Cow() { }

        public Cow(string name)
        {
            this.name = name;
        }

        // Method for getting a Cow to speak!
        private string Speak(string name)
        {
            var speak = $"You hear {name} Mooing from there field. Press Enter to continue";

            return speak;
        }

        // Method for getting a Cow Service!
        private string Service(string name)
        {
            var service = $"{name} is a milk producing cow!! Cows produce milk for you to sell/drink. Press Enter to continue";

            return service;
        }

        // Method for getting what a Cow eats!
        private string Eat(string name)
        {
            var eat = $"Your Cows eat Grass and Hay!! {name} eats waayyyyy to much of it.. Press Enter to continue";

            return eat;
        }

        // Method for Cow water
        private string Drink(string name)
        {
            var drink = $"{name} is drinking some water at the little pond! Press Enter to continue";

            return drink;
        }

        public void CowMenu(string cow1, string cow2, string cow3, string cow4)
        {
            var cowInput = "";

            Console.WriteLine("You arrived at the Cow field! Press Enter to continue");
            Console.ReadLine();
            do
            {
                Console.Clear();
                Console.WriteLine("What would you like to do at the Cow field?");
                Console.WriteLine("1. Listen to the sound a Cow makes?");
                Console.WriteLine("2. See what kind of Service a Cow does?");
                Console.WriteLine("3. See what a Cow eats?");
                Console.WriteLine("4. Have the Cow drink some water?");
                Console.WriteLine("'exit' To exit to Main Menu");
                cowInput = Console.ReadLine().ToLower();

                if (cowInput != "exit")
                {
                    switch (cowInput)
                    {
                        case "1":
                            Console.WriteLine($"{new Cow().Speak(cow1)}");
                            Console.ReadLine();
                            break;
                        case "2":
                            Console.WriteLine($"{new Cow().Service(cow2)}");
                            Console.ReadLine();
                            break;
                        case "3":
                            Console.WriteLine($"{new Cow().Eat(cow3)}");
                            Console.ReadLine();
                            break;
                        case "4":
                            Console.WriteLine($"{new Cow().Drink(cow4)}");
                            Console.ReadLine();
                            break;
                    }
                }

            } while (cowInput != "exit");
        }
    }
}
