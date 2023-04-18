using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.UsingWater
{
    internal class ConcreteUser : User
    {
        public ConcreteUser(double usedWater) : base(usedWater)
        {
        }

        public override double UseWater()
        {
            throw new NotImplementedException();
        }
    }
}
