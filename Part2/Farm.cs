using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2
{
    class Farm
    {
        public Farm()
        {
            Console.WriteLine("Welcome to the farm");
        }
        public void AnimalsSpeek(Horse horse)
        {
            Console.WriteLine(horse.Speak()); 
        }

    }
}
