using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmVille
{
    // Cow Class
    class Cow
    {
        public string name;

        public Cow() { }

        public Cow(string name)
        {
            this.name = name;
        }

        // Method for getting a Cow to speak!
        public string Speak()
        {
            var speak = "You hear the Cow Mooing from its field";

            return speak;
        }

        // Method for getting a Cow to sleep!
        public string Sleep()
        {
            var sleep = "The Cow is asleep in its field!";

            return sleep;
        }

        // Method for getting a Cow to do there Service! Which is to produce Milk
        public string Service(string name)
        {
            var produceMilk = $"You walk up to {name} to see if you can get some milk out of her today. That's generally what cows are for around here.";

            return produceMilk;
        }

        // Method for getting a Cow to eat!
        public string Eat(string name)
        {
            var eat = $"{name} is eating. {name} eats grass and hay!";

            return eat;
        }

        // Method for getting a Cow to drink!
        public string Drink(string name)
        {
            var drink = $"{name} is drinking some water from its trough!";

            return drink;
        }
    }
}
