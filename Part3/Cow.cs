using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part3
{
    class Cow
    {
        string name, speech;
        public Cow(string name,string speech)
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
