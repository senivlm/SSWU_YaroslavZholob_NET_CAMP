using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class DeliveringPump : Pump
    {
        private double _usedVolume;
        private double _reservedVolume;
        List<District> Districts;

        public double VolumeToPump { get;}

        public DeliveringPump(List<District> districts, double volumeToPump): base(volumeToPump)
        {
            Districts = districts;
            foreach (var district in districts)
            {
                _usedVolume += district.CalculateUsedWaterForDistrict();
                _reservedVolume += _usedVolume - district.ApproximateWaterVolume;
            }
        }
        public override bool PumpWaterWithSpecificSpeed(double volumeToPump)
        {
            throw new NotImplementedException();
        }

        public void WaterRedistribution()
        {
            if (_reservedVolume > 0)
            {
                List<District> districtsWithWaterNeed = Districts.Where(d => d.HasDistrictWaterDeficit()).ToList();
                double waterPortion = _reservedVolume / districtsWithWaterNeed.Count;
                districtsWithWaterNeed.ForEach(d => d.UseExtraWaterSupply(waterPortion));
            }
        }
    }
}
