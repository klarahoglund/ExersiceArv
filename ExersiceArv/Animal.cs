using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExersiceArv
{
    public abstract class Animal
    {
        public string Name; 
        public double Weight;
        public int Age;


        //________________________________________________
        //Konstruktor

        public Animal(string name, double weight, int age)
        {
          this.Name = name;
          this.Weight = weight;
          this.Age = age;
        }
        public abstract void DoSound();
        public void PrintAnimal()
        {
            Console.WriteLine($"I am an Animal. My name is {Name} ");
        }
        public virtual string Stats()
        {
            string stats = ($"{Name}, {Weight}, {Age}");
            return stats;
        }
    }
}
