using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExersiceArv
{
    internal class Horse : Animal
    {
        protected bool shoed;

        public Horse(string name, double weight, int age, bool shoed) : base(name, weight, age)
        {
            this.shoed = shoed;
        }
        public override string Stats()
        {
            string stats = base.Stats() + ($", {shoed}");
            return stats;
        }
        public override void DoSound()
        {
            Console.WriteLine("Neeigh");
        }
    }
}
