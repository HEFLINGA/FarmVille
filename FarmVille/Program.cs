using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmVille
{
    class Program
    {
        static void Main(string[] args)
        {
            // Animals in farm - Horses, Cows, Dogs, Chickens, Sheep
            // Methods for Horses   - Speak(), Sleep(), Eat(), Drink(), Service()       - Done!
            // Methods for Cows     - Speak(), Sleep(), Eat(), Drink(), Service()       - Done!
            // Methods for Dogs     - Speak(), Sleep(), Eat(), Service(), Play()        - Done!
            // Methods for Chickens - Speak(), Sleep(), Eat(), Service(),               - 
            // Methods for Sheep    - Service()                                         - 

            // Variables for names
            var characterName = "";

            #region Startup
            Console.WriteLine("Hello there! What's your name friend?");
            characterName = Console.ReadLine();
            Console.WriteLine($"Welcome to FarmVille {characterName}, I heard someone new was going to be taking over the place.. Guess that's you!");
            Console.WriteLine("Press 'enter' to continue: ");
            Console.ReadLine();
            #endregion

            // Instantiating Animals
            // Instantiating Dogs - 
            Dog dog1 = new Dog("Ruby");
            Dog dog2 = new Dog("Bandit");
            Dog dog3 = new Dog("Sugar");

            // Instantiating Horses - 
            Horse horse1 = new Horse("Lightning");
            Horse horse2 = new Horse("MrEd");
            Horse horse3 = new Horse("Butch");

            // Instantiating Cows - 
            Cow cow1 = new Cow("Birtha");
            Cow cow2 = new Cow("Richard");

            // Instantiating Chickens - 


            // Instantiating Sheep - 


            
            


            Console.WriteLine($"I hear {dog1.name} and {dog2.name} {dog1.Speak()}ing up a storm! Those are the other 2 dogs we have here at the farm. They are excited to meet you I think. Press 'enter' to continue: ");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine($"Oh! {dog1.Service(dog1.name)}.");
            Console.WriteLine($"{dog2.Play(dog2.name)} To bad we have some work we gotta get to!");


        }
    }
}
