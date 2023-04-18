using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class WaterTowerSimulator
    {
        public static WaterTower Initialization()
        {
            WaterTowerPump waterTowerPump = new WaterTowerPump(100, 40);
            WaterTower waterTower = new ConcreteWaterTower(waterTowerPump, 100000);
            return waterTower;
        }
        public static void Simulate()
        {
            var tower = Initialization();
            tower.PumpWater();
        }
    }
}
