using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmVilleStep4
{
    // Sheep Class
    class Sheep
    {
        // Methods for Sheep    - Speak(), Eat(), Service(), Play()        - 

        public string name;

        public Sheep() { }

        public Sheep(string name)
        {
            this.name = name;
        }

        // Method for getting a Sheep to speak!
        private string Speak(string name)
        {
            var speak = $"You hear {name} BAHHHing in the distance. Press Enter to continue";

            return speak;
        }

        // Method for getting a Sheep Service!
        private string Service(string name)
        {
            var service = $"{name} is a wool producing sheep!! You get all of your nice sweaters from {name}. Press Enter to continue";

            return service;
        }

        // Method for getting what a Sheep eats!
        private string Eat(string name)
        {
            var eat = $"Your Sheep eat grass and hay.. You even use {name} to mow your lawn sometimes. Press Enter to continue";

            return eat;
        }

        // Method for Playing with your Sheep
        private string Play(string name)
        {
            var play = $"Sheep Love to play! {name} does get a little rough sometimes though, and knocks you over. Press Enter to continue";

            return play;
        }

        public void SheepMenu(string sheep1, string sheep2, string sheep3, string sheep4)
        {
            var sheepInput = "";

            Console.WriteLine("You see the sheep barn! Press Enter to continue");
            Console.ReadLine();
            do
            {
                Console.Clear();
                Console.WriteLine("What would you like to do at the Sheep coop?");
                Console.WriteLine("1. Listen to the sound a Sheep makes?");
                Console.WriteLine("2. See what kind of Service a Sheep does?");
                Console.WriteLine("3. See what a Sheep eats?");
                Console.WriteLine("4. Watch your Sheep play??");
                Console.WriteLine("'exit' To exit to Main Menu");
                sheepInput = Console.ReadLine().ToLower();

                if (sheepInput != "exit")
                {
                    switch (sheepInput)
                    {
                        case "1":
                            Console.WriteLine($"{new Sheep().Speak(sheep1)}");
                            Console.ReadLine();
                            break;
                        case "2":
                            Console.WriteLine($"{new Sheep().Service(sheep2)}");
                            Console.ReadLine();
                            break;
                        case "3":
                            Console.WriteLine($"{new Sheep().Eat(sheep3)}");
                            Console.ReadLine();
                            break;
                        case "4":
                            Console.WriteLine($"{new Sheep().Play(sheep4)}");
                            Console.ReadLine();
                            break;
                    }
                }

            } while (sheepInput != "exit");
        }
    }
}
