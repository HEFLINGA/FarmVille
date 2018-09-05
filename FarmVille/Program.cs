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
            // Methods for Horses   - Speak(), Eat(), Sleep(), Drink()                  - 
            // Methods for Cows     - Speak(), Eat(), Sleep(), Drink(), ProduceMilk     - 
            // Methods for Dogs     - Speak(), Sleep(), Heard(), Play()                 - Done!
            // Methods for Chickens - Speak(), Sleep(), LayEggs(), Eat()                - 
            // Methods for Sheep    - Speak(), Sleep(), Graze(), SheerWool()            - 
                
            // Variables for names
            var characterName = "";
            var dogName = "";

            #region Startup
            Console.WriteLine("Hello there! What's your name friend?");
            characterName = Console.ReadLine();
            Console.WriteLine($"Welcome to FarmVille {characterName}, I heard someone new was going to be taking over the place.. Guess that's you!");
            Console.WriteLine("Press 'enter' to continue: ");
            Console.ReadLine();

            Console.WriteLine("Well look who it is! The farm dog. What would you like to name him?");
            dogName = Console.ReadLine();
            Console.WriteLine($"Ahh, {dogName}. That's a good name.");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            #endregion

            // Instantiating Animals
            // Instantiating Dogs - 
            Dog dog1 = new Dog("Ruby");
            Dog dog2 = new Dog("Bandit");
            Dog dog3 = new Dog("Sugar");

            // Instantiating Chickens - 

            // Instantiating Sheep - 

            // Instantiating Cows - 

            // Instantiating Horses - 

            Console.WriteLine($"I hear {dog1.name} and {dog2.name} {dog1.Speak()}ing up a storm! Those are the other 2 dogs we have here at the farm. They are excited to meet you I think. Press 'enter' to continue: ");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine($"Oh! {dog1.Heard(dog1.name)}.");
            Console.WriteLine($"{dog2.Play(dog2.name)} To bad we have some work we gotta get to!");


        }
    }
}
