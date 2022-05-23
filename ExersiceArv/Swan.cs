using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExersiceArv
{
    internal class Swan : Bird
    {
        protected int numberOfNestlings;

        public Swan(string name, double weight, int age, bool marked, int numberOfNestlings) : base(name, weight, age, marked)
        {
            this.numberOfNestlings = numberOfNestlings;
        }

        public int NumberOfNestlings
        { get { return numberOfNestlings; } set { numberOfNestlings = value; } }

        public override string Stats()
        {
            string stats = base.Stats() + ($", {numberOfNestlings}");
            return stats;
        }

    }
}
