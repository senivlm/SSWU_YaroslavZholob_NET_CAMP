using ConsoleApp1.UsingWater;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class WaterSupplySystem
    {
        //Simulating pumpimg water to water tower
        public void SimulatePumpingWater()
        {
            WaterTowerSimulator.Initialization();
            WaterTowerSimulator.Simulate();
        }
        //Users use water
        public void WaterUsage()
        {
            List<User> concreteUsers = new List<User>();
            // Тут хардкоду точно не треба. найкраще мати класи генераторів, побудовані за різними стратегіями.
            concreteUsers.AddRange(new List<ConcreteUser>{ new ConcreteUser(20), new ConcreteUser(30), new ConcreteUser(40), 
                                                           new ConcreteUser(50), new ConcreteUser(15), new ConcreteUser(200),
                                                           new ConcreteUser(20), new ConcreteUser(60), new ConcreteUser(100)});
            District Lviv = new District("Lviv District", 700, concreteUsers);

            DeliveringPump deliveringPump = new DeliveringPump(new List<District> { Lviv }, 1000);

            deliveringPump.PumpWaterWithSpecificSpeed(deliveringPump.VolumeToPump);

            deliveringPump.WaterRedistribution();
        }
    }
}
