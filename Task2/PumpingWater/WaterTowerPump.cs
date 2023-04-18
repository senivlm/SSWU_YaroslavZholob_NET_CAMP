using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class WaterTowerPump : Pump
    {
        public WaterTowerPump(double volumeToPump=10000, double power = 20, double speed = 20) : base(volumeToPump, power, speed)
        {
        }

        public override bool PumpWaterWithSpecificSpeed(double volumeToPump)
        {
            throw new NotImplementedException();
        }
    }
}
