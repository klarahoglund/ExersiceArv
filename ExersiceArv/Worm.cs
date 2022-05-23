using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExersiceArv
{
    internal class Worm : Animal
    {

        protected int speed;

        public Worm(string name, double weight, int age, int speed) : base(name, weight, age)
        {
            this.speed = speed; 
        }

        public override void DoSound()
        {
            Console.WriteLine("Slimy slim");
        }
        public override string Stats()
        {
            string stats = base.Stats() + ($", {speed}");
            return stats;
        }
    }
}
