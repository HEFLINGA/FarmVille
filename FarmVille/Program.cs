using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmVilleStep4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Animals in farm - Horses, Cows, Dogs, Chickens, Sheep
            // Methods for Horses   - Speak(), Eat(), Drink(), Service()       -
            // Methods for Cows     - Speak(), Eat(), Drink(), Service()       -
            // Methods for Dogs     - Speak(), Eat(), Service(), Play()        -
            // Methods for Chickens - Speak(), Eat(), Service(), Food()        - 
            // Methods for Sheep    - Speak(), Eat(), Service(), Play()        - 

            var name = "";

            // Getting the name of dog1
            Console.WriteLine("Hello! Before you get to the farm, you need to name your dog! Most the animals on the farm already have names.. but there is one dog here who still needs one!! Go ahead and put in the name now: ");
            name = Console.ReadLine();
            Console.WriteLine($"Alright! {name} is an execellent name. Anyways! lets head out. Press 'enter' to continue");
            Console.ReadLine();

            #region Farm animals Instantiation
            // Instantiating Horses
            Horse horse1 = new Horse("Lightning");
            Horse horse2 = new Horse("Hurby");
            Horse horse3 = new Horse("Zippy");
            Horse horse4 = new Horse("Pearl");

            // Instantiating Cows
            Cow cow1 = new Cow("Rob");
            Cow cow2 = new Cow("Birtha");
            Cow cow3 = new Cow("Daisy");
            Cow cow4 = new Cow("Cher");

            // Instantiating Dogs
            Dog dog1 = new Dog(name);
            Dog dog2 = new Dog("Genny");
            Dog dog3 = new Dog("Ruby");
            Dog dog4 = new Dog("Franks");

            // Instantiating Chickens
            Chicken chicken1 = new Chicken("Cluckyy");
            Chicken chicken2 = new Chicken("Chicken Little");
            Chicken chicken3 = new Chicken("Sall");
            Chicken chicken4 = new Chicken("Rickky");

            // Instantiating Sheep
            Sheep sheep1 = new Sheep("Fran");
            Sheep sheep2 = new Sheep("bill");
            Sheep sheep3 = new Sheep("Hercules");
            Sheep sheep4 = new Sheep("Paracleas");
            #endregion

            var input = "";
            
            // Program loop
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1. Go to the Horse corral");
                Console.WriteLine("2. Go to the field where the Cows are");
                Console.WriteLine("3. Go visit your Dogs");
                Console.WriteLine("4. Go to the Chicken coop");
                Console.WriteLine("5. Go to your Sheep barn");
                Console.WriteLine("'exit' To exit program");
                input = Console.ReadLine().ToLower();
                Console.ForegroundColor = ConsoleColor.DarkYellow;

                // Input for menus
                if (input != "exit")
                {
                    switch (input)
                    {
                        case "1":
                            new Horse().HorseMenu(horse1.name, horse2.name, horse3.name, horse4.name);
                            Console.WriteLine("Press 'enter' to continue");
                            break;
                        case "2":
                            new Cow().CowMenu(cow1.name, cow2.name, cow3.name, cow4.name);
                            Console.WriteLine("Press 'enter' to continue");
                            break;
                        case "3":
                            new Dog().DogMenu(dog1.name, dog2.name, dog3.name, dog4.name);
                            Console.WriteLine("Press 'enter' to continue");
                            break;
                        case "4":
                            new Chicken().ChickenMenu(chicken1.name, chicken2.name, chicken3.name, chicken4.name);
                            Console.WriteLine("Press 'enter' to continue");
                            break;
                        case "5":
                            new Sheep().SheepMenu(sheep1.name, sheep2.name, sheep3.name, sheep4.name);
                            Console.WriteLine("Press 'enter' to continue");
                            break;
                        default:
                            Console.WriteLine("Please input a number between 1 and 5, or 'exit' to exit the program: ");
                            break;
                    }
                }

            } while (input != "exit");
        }
    }
}
