using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExersiceArv
{
    internal class Dog : Animal

    {
        protected bool tail;

        public bool getTail
        {
            get { return tail; }
            set { tail = value; }
        }

        public Dog(string name, double weight, int age, bool tail) : base(name, weight, age)
        {
            this.tail = tail;
        }

        public override void DoSound()
        {
            Console.WriteLine("Woof Woff");
        }
        public override string Stats()
        {
            string stats = base.Stats() + ($", {tail}");
            return stats;
        }
        public string WiggleTail()
        {
            return "Wiggle, Wiggle";
        }
        public void PrintDog()
        {
            Console.WriteLine($"This Dog id named {Name} and has a tail = {tail}");
           
        }
    }
}
