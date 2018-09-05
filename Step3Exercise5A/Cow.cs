using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step3Exercise5A
{
    // Cow class
    class Cow
    {
        public string name;

        public Cow() { }

        public Cow(string name)
        {
            this.name = name;
        }

        // Method for getting a Cow to speak!
        public string Speak(string name)
        {
            var speak = $"You hear the Cow {name} Mooing from the field";

            return speak;
        }

        public void CowMenu(string cow1, string cow2, string cow3, string cow4)
        {
            var cowInput = "";

            Console.WriteLine("You arrived at the Cow field! Press Enter to continue");
            Console.ReadLine();           
            do
            {
                Console.Clear();
                Console.WriteLine("What would you like to do at the Cow field?");
                Console.WriteLine("1. Listen to the sound a Cow makes?");
                Console.WriteLine("2. See what kind of Service a Cow does?");
                Console.WriteLine("3. See what a Cow eats?");
                Console.WriteLine("4. Have the Cow drink some water?");
                Console.WriteLine("'exit' To exit to Main Menu");
                cowInput = Console.ReadLine().ToLower();

                if (cowInput != "exit")
                {
                    switch (cowInput)
                    {
                        case "1":
                            Console.WriteLine($"{new Cow().Speak(cow1)}");
                            Console.ReadLine();
                            break;
                        case "2":
                            throw new NotImplementedException("No Cow Service Method built yet");
                        case "3":
                            throw new NotImplementedException("No Cow Eating Method built yet");
                        case "4":
                            throw new NotImplementedException("No Cow Drinking Method built yet");
                    }
                }

            } while (cowInput != "exit");
        }
    }
}
