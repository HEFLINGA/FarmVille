using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step2Exercise5A
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Animals in farm - Horses, Cows, Dogs, Chickens, Sheep
            // Methods for Horses   - Speak(), Sleep(), Eat(), Drink(), Service()       -
            // Methods for Cows     - Speak(), Sleep(), Eat(), Drink(), Service()       -
            // Methods for Dogs     - Speak(), Sleep(), Eat(), Service(), Play()        -
            // Methods for Chickens - Speak(), Sleep(), Eat(), Service(),               - 
            // Methods for Sheep    - Service()                                         - 

            //Instantiate Horse class
            Horse horse1 = new Horse("Lightning");
            Horse horse2 = new Horse("Hurby");
            Horse horse3 = new Horse("Zippy");
            Horse horse4 = new Horse("Pearl");

            var input = "";

            do
            {
                Console.Clear();
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1. Go to the Horse corral");
                Console.WriteLine("2. Go to the field where the Cows are");
                Console.WriteLine("3. Go visit your Dogs");
                Console.WriteLine("4. Go to the Chicken coop");
                Console.WriteLine("5. Go to your Sheep barn");
                input = Console.ReadLine().ToLower();
                if (input != "exit")
                {
                    switch (input)
                    {
                        case "1":
                            new Horse().HorseMenu(horse1.name, horse2.name, horse3.name, horse4.name);
                            Console.WriteLine("Press 'enter' to continue");
                            break;
                        case "2":
                            throw new NotImplementedException("No Cow Class built yet");
                        case "3":
                            throw new NotImplementedException("No Dog Class built yet");
                        case "4":
                            throw new NotImplementedException("No Chicken Class built yet");
                        case "5":
                            throw new NotImplementedException("No Sheep Class built yet");
                        default:
                            Console.WriteLine("Please input a number between 1 and 5, or 'exit' to exit the program: ");
                            break;
                    }
                }

            } while (input != "exit");           
        }
    }
}
    