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
        // Methods for Dogs     - Speak(), Eat(), Service(), Play()        -

        public string name;

        public Dog() { }

        public Dog(string name)
        {
            this.name = name;
        }

        // Method for getting a Dog to speak!
        private string Speak(string name)
        {
            var speak = $"You hear {name} Barking. Press Enter to continue";

            return speak;
        }

        // Method for getting a Dog Service!
        private string Service(string name)
        {
            var service = $"{name} is a Hearding dog!! They help you with all the other animals. Press Enter to continue";

            return service;
        }

        // Method for getting what a Dog eats!
        private string Eat(string name)
        {
            var eat = $"Your Dogs eat Dog food.. and {name} steals food off the counter.. Press Enter to continue";

            return eat;
        }

        // Method for Playing with your Dogs
        private string Play(string name)
        {
            var play = $"{name} Would love to play!! They are so excited! Press Enter to continue";

            return play;
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
                            Console.WriteLine($"{new Dog().Service(dog2)}");
                            Console.ReadLine();
                            break;
                        case "3":
                            Console.WriteLine($"{new Dog().Eat(dog3)}");
                            Console.ReadLine();
                            break;
                        case "4":
                            Console.WriteLine($"{new Dog().Play(dog4)}");
                            Console.ReadLine();
                            break;
                    }
                }

            } while (dogInput != "exit");
        }
    }
}
