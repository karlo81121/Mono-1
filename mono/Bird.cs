using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mono
{
    public class Bird : Animal, IAnimal
    {  
        public string Species { get; set; }
        public double Wingspan { get; set; }

        public Bird(int age, double weight, string type, string species,bool legs, double wingspan) : base(age, weight, type, legs)
        {
            this.Age = age;
            this.Weight = weight;
            this.Type = type;
            this.Species = species;
            this.Legs = legs;
            this.Wingspan = wingspan;
        }

        public void MeasureWingspan()
        {
            if (Wingspan >= 0.1 && Wingspan <= 0.3)
            {
                Console.WriteLine("small bird");
            }
            else if(Wingspan > 0.3 && Wingspan <= 0.5)
            {
                Console.WriteLine("medium size bird");
            }
            else
            {
                Console.WriteLine("big bird");
            }
        }

        public void EatFood()
        {
            Console.WriteLine("Bird eating...");
        }

        public void Sleep()
        {
            Console.WriteLine("Bird sleeping...");
        }

        public void Run()
        {
            Console.WriteLine("Birds can't run...");
        }

    }
}
