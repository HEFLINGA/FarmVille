using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmVille
{
    // Horse class
    class Horse
    {
        public string name;

        public Horse() { }

        public Horse(string name)
        {
            this.name = name;
        }

        // Method for getting a Horse to speak!
        public string Speak()
        {
            var speak = "You hear the horse whinny and neigh in the distance";

            return speak;
        }

        // Method for getting a Horse to sleep!
        public string Sleep()
        {
            var sleep = "The Horse is asleep in its pasture!";

            return sleep;
        }

        // Method for getting a Horse to do there Service! Which is to Haul Goods
        public string Service(string name)
        {
            var haul = $"And off {name} went! Hauling another load to its destination! Thats what Horses do around here generally.";

            return haul;
        }

        // Method for getting a Horse to eat!
        public string Eat(string name)
        {
            var eat = $"{name} is eating. {name} eats hay!";

            return eat;
        }

        // Method for getting a Horse to drink!
        public string Drink(string name)
        {
            var drink = $"{name} is drinking some water!";

            return drink;
        }
    }
}
