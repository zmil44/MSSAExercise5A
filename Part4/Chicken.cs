using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1
{
    class Chicken
    {
    
        string name, speech,food,productProvided;
        public Chicken(string name, string speech, string food, string productProvided)
        {
            this.name = name;
            this.speech = speech;
            this.food = food;
            this.productProvided = productProvided;
        }
        public string Name()
        {
            return name;
        }
        public string Speak()
        {
            return speech;
        }
        public string Eat()
        {
            return food;
        }
        public string ProductProvided()
        {
            return productProvided;
        }
    }
}

