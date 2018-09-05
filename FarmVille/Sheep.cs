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
        public string Speak(string name)
        {
            var speak = $"You hear {name} running around going \"BAAHHHH\"!";

            return speak;
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
                            throw new NotImplementedException("No Sheep Service Method built yet");
                        case "3":
                            throw new NotImplementedException("No Sheep Eating Method built yet");
                        case "4":
                            throw new NotImplementedException("No Sheep Playing Method built yet");
                    }
                }

            } while (sheepInput != "exit");
        }
    }
}
