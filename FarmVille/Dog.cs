using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmVilleStep4
{
    // Dog class
    class Dog
    {
        public string name;

        public Dog() { }

        public Dog(string name)
        {
            this.name = name;
        }

        // Method for getting a Dog to speak!
        public string Speak(string name)
        {
            var speak = $"You hear the Dog {name} Barking!";

            return speak;
        }

        public void DogMenu(string dog1, string dog2, string dog3, string dog4)
        {
            var dogInput = "";

            Console.WriteLine("You see the dogs!! Press Enter to continue");
            Console.ReadLine();
            do
            {
                Console.Clear();
                Console.WriteLine("What would you like to do at the here with the dogs?");
                Console.WriteLine("1. Listen to the sound a dog makes?");
                Console.WriteLine("2. See what kind of Service a dog does?");
                Console.WriteLine("3. See what a dog eats?");
                Console.WriteLine("4. Play with your dog??");
                Console.WriteLine("'exit' To exit to Main Menu");
                dogInput = Console.ReadLine().ToLower();

                if (dogInput != "exit")
                {
                    switch (dogInput)
                    {
                        case "1":
                            Console.WriteLine($"{new Dog().Speak(dog1)}");
                            Console.ReadLine();
                            break;
                        case "2":
                            throw new NotImplementedException("No Dog Service Method built yet");
                        case "3":
                            throw new NotImplementedException("No Dog Eating Method built yet");
                        case "4":
                            throw new NotImplementedException("No Dog Playing Method built yet");
                    }
                }

            } while (dogInput != "exit");
        }
    }
}
