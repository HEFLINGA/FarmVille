using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmVilleStep4
{
    // Chicken Class
    class Chicken
    {
        // Methods for Chickens - Speak(), Eat(), Service(), Food()        - 

        public string name;

        public Chicken() { }

        public Chicken(string name)
        {
            this.name = name;
        }

        // Method for getting a Chickens to speak!
        private string Speak(string name)
        {
            var speak = $"You hear {name} clucking around inside. Press Enter to continue";

            return speak;
        }

        // Method for getting a Chickens Service!
        private string Service(string name)
        {
            var service = $"{name} is an egg laying chicken! You get all your eggs for breakfast from {name}. Press Enter to continue";

            return service;
        }

        // Method for getting what a Chickens eats!
        private string Eat(string name)
        {
            var eat = $"Your chickens eat Bugs and seeds! {name} Eats anything they can get there hands on. Press Enter to continue";

            return eat;
        }

        // Method for getting Food from your chickens
        private string Food(string name)
        {
            var food = $"You looked everywhere for {name}... You Planned to have chicken for dinner tonight, but it looks like {name} has other plans. Press Enter to continue";

            return food;
        }

        public void ChickenMenu(string chicken1, string chicken2, string chicken3, string chicken4)
        {
            var chickenInput = "";

            Console.WriteLine("You see the chicken coop! Press Enter to continue");
            Console.ReadLine();
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("What would you like to do at the chicken coop?");
                Console.WriteLine("1. Listen to the sound a chicken makes?");
                Console.WriteLine("2. See what kind of Service a chicken does?");
                Console.WriteLine("3. See what a chicken eats?");
                Console.WriteLine("4. Get food from your chicken??");
                Console.WriteLine("'exit' To exit to Main Menu");
                chickenInput = Console.ReadLine().ToLower();
                Console.ForegroundColor = ConsoleColor.DarkYellow;

                if (chickenInput != "exit")
                {
                    switch (chickenInput)
                    {
                        case "1":
                            Console.WriteLine($"{new Chicken().Speak(chicken1)}");
                            Console.ReadLine();
                            break;
                        case "2":
                            Console.WriteLine($"{new Chicken().Service(chicken2)}");
                            Console.ReadLine();
                            break;
                        case "3":
                            Console.WriteLine($"{new Chicken().Eat(chicken3)}");
                            Console.ReadLine();
                            break;
                        case "4":
                            Console.WriteLine($"{new Chicken().Food(chicken4)}");
                            Console.ReadLine();
                            break;
                    }
                }

            } while (chickenInput != "exit");
        }
    }
}
