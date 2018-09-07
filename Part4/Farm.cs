using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1
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
            Console.WriteLine($"{ed.Name()} {ed.Speak()} {ed.Eat()} {ed.ProductProvided()}" +
                $"\n{bessie.Name()} {bessie.Speak()} {bessie.Eat()} {bessie.ProductProvided()}" +
                $"\n{babe.Name()} {babe.Speak()} {babe.Eat()} {babe.ProductProvided()}" +
                $"\n{attilaTheHen.Name()} {attilaTheHen.Speak()} {attilaTheHen.Eat()} {attilaTheHen.ProductProvided()}");
        }
    }
}
