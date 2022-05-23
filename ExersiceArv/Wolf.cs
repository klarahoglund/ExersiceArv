using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExersiceArv
{
    internal class Wolf : Animal
    {

        protected int numberOfteeth;

        public Wolf(string name, double weight, int age, int numberOfteeth) : base(name, weight, age)
        {
            this.numberOfteeth = numberOfteeth; 
        }

        public override void DoSound()
        {
            Console.WriteLine("Owoooooo");
        }
        public override string Stats()
        {
            string stats = base.Stats() + ($", {numberOfteeth}");
            return stats;
        }

    }
}
