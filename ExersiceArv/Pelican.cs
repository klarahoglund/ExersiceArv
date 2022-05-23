using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExersiceArv
{
    internal class Pelican : Bird
    {
        protected double beak;
        public  double getBeak
        {
            get { return beak; }
            set { beak = value; }
        }

        public Pelican(string name, double weight, int age, bool marked, double beak) : base(name, weight, age, marked)
        {
            this.beak = beak;   
        }
        public override string Stats()
        {
            string stats = base.Stats() + ($", {beak}");
            return stats;
        }
    }
}
