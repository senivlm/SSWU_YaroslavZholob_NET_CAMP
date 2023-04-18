using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class District
    {
        public string Name { get; }
        public double ApproximateWaterVolume { get; private set; }
        private double UsedWater { get; set; }
        public List<User> Users { get; }

        public District(string name, double volume, List<User> users)
        {
            Name = name;
            Users = users;
            ApproximateWaterVolume = volume;
        }
        public double CalculateUsedWaterForDistrict()
        {
            foreach (var user in Users)
            {
                UsedWater += user.CalculateUsedWater();
            }
            return UsedWater;
        }
        public void UseExtraWaterSupply(double volume)
        {
            ApproximateWaterVolume += volume;
        }

        public bool HasDistrictWaterDeficit()
        {
            return UsedWater > ApproximateWaterVolume;
        }

        public override string? ToString()
        {
            return $"District:{Name}. With approximate water consumption:{ApproximateWaterVolume}";
        }
    }
}
