using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part3
{
    class Pig
    {
        string name, speech;
        public Pig(string name, string speech)
        {
            this.name = name;
            this.speech = speech;
        }

        public string Speak()
        {
            return speech;
        }
    }
}
