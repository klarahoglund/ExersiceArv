using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExersiceArv
{
    internal class Flamingo : Bird
    {
        protected double lengthOfLegs;

        public double LengthOfLegs
        {
            get { return lengthOfLegs; }
            set { lengthOfLegs = value; }   
        }

        public Flamingo(string name, double weight, int age, bool marked, double lengthOfLegs) : base(name, weight, age, marked)
        {
            this.lengthOfLegs = lengthOfLegs;   
        }

        public override string Stats()
        {
            string stats = base.Stats() + ($", {lengthOfLegs}");
            return stats;
        }
    }
}
