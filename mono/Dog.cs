using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mono
{
        class Dog : Animal, IAnimal
        {
        public string Species { get; set; }
        public string Name { get; set; }

        public Dog(int age, double weight, string type, string species,bool legs, string name) : base(age, weight, type, legs)
        {
            this.Age = age;
            this.Weight = weight;
            this.Type = type;
            this.Legs = legs;
            this.Species = species;
            this.Name = name;
        }

        public int CountDogAgeInPeopleAge()
        {
            int dogAge = Age;
            return dogAge * 7;           
        }

        public void workWithDog()
        {
            
        }

        public void EatFood()
        {
            Console.WriteLine("Dog eating...");
        }

        public void Run()
        {
            Console.WriteLine("Dog running...");
        }

        public void Sleep()
        {
            Console.WriteLine("Dog sleeping...");
        }
    }
}
