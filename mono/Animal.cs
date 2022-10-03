using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mono
{
    public abstract class Animal
    {
        public int Age { get; set; }
        public double Weight { get; set; }
        public string Type { get; set; }
        public bool Legs { get; set; }

        public Animal(int age, double weight, string type, bool legs)
        {
            this.Age = age;
            this.Weight = weight;
            this.Type = type;
            this.Legs = legs;
        }
    }
}
