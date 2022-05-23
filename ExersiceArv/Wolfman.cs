using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExersiceArv
{
    internal class Wolfman : Wolf, IPerson
    {
        public Wolfman(string name, double weight, int age, int numberOfteeth) : base(name, weight, age, numberOfteeth)
        {
        }

        public void Talk()
        {
            Console.WriteLine("I am wolfman. I am talking because of the interface IPerson");
        }

    }
}
