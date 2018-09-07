using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part3
{
    class Program
    {
        static void Main(string[] args)
        {

            //requirement for part three is to create four farm animasl and have one method for each
            try
            {
                Farm newFarm = new Farm();
                Horse ed = new Horse("Mr. Ed", "Hello, I am Mr. Ed and I say Neigh because I'm a horse.");
                Cow bessie = new Cow("Bessie", "Hello, I am Bessie and I say Moo because I'm a cow");
                Pig babe = new Pig("Babe", "Hello, I am Babe and I say oink because I'm a pig");
                Chicken attilaTheHen = new Chicken("Attila the Hen", "Hello, I am Attila the Hen and I say cluck because I'm a chicken");
                newFarm.AnimalsSpeak(ed, bessie, babe, attilaTheHen);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
        }
    }
}
