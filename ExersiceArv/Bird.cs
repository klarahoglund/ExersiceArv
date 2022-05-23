using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExersiceArv
{
    internal class Bird : Animal

    {
        protected bool marked = false;

        public Bird(string name, double weight, int age, bool marked) : base(name, weight, age)
        {
            this.marked = marked;
        }

        public override void DoSound()
        {
            Console.WriteLine("Tweet Tweet");
        }
        public override string Stats()
        {
            string stats = base.Stats() + ($", {marked}");
            return stats;
        }
        public void PrintBird()
        {
            Console.WriteLine($"This Bird id named {Name} ");
            if (marked)
            {
                Console.WriteLine($"{Name} is marked");
            }
            else
            {
                Console.WriteLine($"{Name} is not marked");
            }

        }
    }
}
