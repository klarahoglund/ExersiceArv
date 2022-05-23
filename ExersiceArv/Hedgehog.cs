using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExersiceArv
{
    internal class Hedgehog : Animal
    {
        protected int tags;

        public Hedgehog(string name, double weight, int age, int tags) : base(name, weight, age)
        {
            this.tags = tags;
        }

        public override void DoSound()
        {
            Console.WriteLine("Swiggle Swiggle");
        }
        public override string Stats()
        {
            string stats = base.Stats() + ($", {tags}");
            return stats;
        }
    }
}
