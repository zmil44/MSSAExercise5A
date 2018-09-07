using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2
{
    class Program
    {
        static void Main(string[] args)
        {

            //requirement for part two is to create one farm animal by creating a class and a method 
            try
            {
                Farm newFarm = new Farm();
                Horse ed = new Horse("Mr. Ed","Hello, I am Mr. Ed and I say Neigh because I'm a horse.");
                newFarm.AnimalsSpeak(ed);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
        }
    }

}
