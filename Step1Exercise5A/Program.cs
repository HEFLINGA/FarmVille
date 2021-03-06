﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step1Exercise5A
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
                            throw new NotImplementedException("No Horse Class built yet");
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
