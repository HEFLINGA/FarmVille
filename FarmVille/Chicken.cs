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

        // Method for getting a Chicken to speak!
        public string Speak(string name)
        {
            var speak = $"You hear the clucking of your chicken {name}!";

            return speak;
        }

        public void ChickenMenu(string chicken1, string chicken2, string chicken3, string chicken4)
        {
            var chickenInput = "";

            Console.WriteLine("You see the chicken coop! Press Enter to continue");
            Console.ReadLine();
            do
            {
                Console.Clear();
                Console.WriteLine("What would you like to do at the chicken coop?");
                Console.WriteLine("1. Listen to the sound a chicken makes?");
                Console.WriteLine("2. See what kind of Service a chicken does?");
                Console.WriteLine("3. See what a chicken eats?");
                Console.WriteLine("4. Get food from your chicken??");
                Console.WriteLine("'exit' To exit to Main Menu");
                chickenInput = Console.ReadLine().ToLower();

                if (chickenInput != "exit")
                {
                    switch (chickenInput)
                    {
                        case "1":
                            Console.WriteLine($"{new Chicken().Speak(chicken1)}");
                            Console.ReadLine();
                            break;
                        case "2":
                            throw new NotImplementedException("No Chicken Service Method built yet");
                        case "3":
                            throw new NotImplementedException("No Chicken Eating Method built yet");
                        case "4":
                            throw new NotImplementedException("No Chicken Food Method built yet");
                    }
                }

            } while (chickenInput != "exit");
        }
    }
}
