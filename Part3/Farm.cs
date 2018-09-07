using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part3
{
    class Farm
    {
        public Farm()
        {
            Console.WriteLine("Welcome to the farm");
        }
        internal void AnimalsSpeak(Horse ed, Cow bessie, Pig babe, Chicken attilaTheHen)
        {
            Console.WriteLine("The animals of the farm would like to introduce themselves.");
            Console.WriteLine($"{ed.Speak()}\n{bessie.Speak()}\n{babe.Speak()}\n{attilaTheHen.Speak()}");
        }
    }
}
