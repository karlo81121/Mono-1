using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mono
{
    public class Snake : Animal, IAnimal
    {
        public string Species { get; set; }    
        public double Length { get; set; }

        public Snake(int age, double weight, string type, string species, bool legs, double length) : base(age, weight, type, legs)
        {
            this.Age = age;
            this.Weight = weight;
            this.Type = type;
            this.Species = species;
            this.Legs = legs;
            this.Length = length;
        }

        public void EatFood()
        {
            Console.WriteLine("Snake eating...");
        }

        public void Run()
        {
            Console.WriteLine("Snake can't run...");
        }

        public void Sleep()
        {
            Console.WriteLine("Snake Sleeping...");
        }
    }

}
