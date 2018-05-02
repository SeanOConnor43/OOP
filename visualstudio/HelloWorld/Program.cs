using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Color
    {
        public float r, g, b;
    }
    class Dog
    {
        public string name;
        public int size;
        public string breed;
        public Color color;

        public void Speak()
        {
            Console.WriteLine(name + " says: Woof!");
        }
        public void Walk()
        {
            Console.WriteLine(name + " is walking.");
        }
        public void Eat(string food)
        {
            Console.WriteLine(name + " is eating " + food + ".");
        }
        public void Shit()
        {
            Console.WriteLine(name + " is shitting.");
        }
        public void Sleep()
        {
            Console.WriteLine(name + " is sleeping.");
        }

    }
    class Program
    {
        public static string help = @"Welcome to shitty dog Simulator
        ";
        static void Main(string[] args)
        {
            
            bool quit = false;
            string inThing;
            while (quit == false)
            {
               
            }
            
        }
    }
}
