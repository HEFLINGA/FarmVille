using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmVille
{
    class Dog
    {
        public string name;

        public Dog() { }

        public Dog(string name)
        {
            this.name = name;
        }

        public string Speak()
        {
            var speak = "Bark";

            return speak;
        }

        public string Sleep()
        {
            var sleep = "The dog is asleep!";

            return sleep;
        }

        public string Heard(string name)
        {
            var heard = $"And off {name} went! Hearding Animals!";

            return heard;
        }

        public string Play(string name)
        {
            var play = $"Ahhh, {name} wants to play!!";

            return play;
        }
    }
}
