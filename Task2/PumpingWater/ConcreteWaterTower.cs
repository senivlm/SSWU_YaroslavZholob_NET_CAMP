using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ConcreteWaterTower : WaterTower
    {
        public ConcreteWaterTower(Pump _pump, double volumeMax = 10000) : base(_pump, volumeMax)
        {
        }
        public override void DistributeWater()
        {
            throw new NotImplementedException();
        }
    }
}
