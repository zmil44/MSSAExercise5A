using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            //requirement for part three is to create four farm animasl and have four methods for each
            try
            {
                Farm newFarm = new Farm();
                Horse ed = new Horse("Hello, I'm Mr. Ed", "and I say Neigh because I'm a horse.", "I eat grass.","I provide transportation");
                Cow bessie = new Cow("Hello, I'm Bessie", "and I say Moo because I'm a cow.", "I eat hay and cord.", "I provide beef.");
                Pig babe = new Pig("Hello, I'm Babe", "and I say oink because I'm a pig.","I eat corn.","I provide pork");
                Chicken attilaTheHen = new Chicken("Hello, I'm Atilla the Hen", "and I say cluck because I'm a chicken.", 
                    "I eat grains and seeds.", "I provide eggs.");
                newFarm.AnimalsSpeak(ed, bessie, babe, attilaTheHen);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
        }
    }

}
