using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal abstract class User
    {
        private double _usedWater;

        public User(double usedWater)
        {
            _usedWater = usedWater;
        }

        public double CalculateUsedWater()
        {
            return _usedWater += UseWater();
        }
        public abstract double UseWater();

        public override string? ToString()
        {
            return $"User used water:{_usedWater}";
        }
    }
}
