using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmVille
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

        // Method for getting a dog to speak!
        public string Speak()
        {
            var speak = "The Dog Barks";

            return speak;
        }

        // Method for getting a dog to sleep!
        public string Sleep()
        {
            var sleep = "The dog is asleep!";

            return sleep;
        }

        // Method for getting a dog to do there Service! Which is Hearding animals
        public string Service(string name)
        {
            var heard = $"And off {name} went! Hearding Animals! Thats what dogs do around here generally.";

            return heard;
        }

        // Method for getting a dog to Play!
        public string Play(string name)
        {
            var play = $"Ahhh, {name} wants to play!!";

            return play;
        }

        // Method for getting a dog to Eat!
        public string Eat(string name)
        {
            var eat = $"{name} is eating some food!";

            return eat;
        }
    }
}
