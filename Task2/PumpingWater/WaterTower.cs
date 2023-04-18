using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal abstract class WaterTower
    {
        private readonly double _maxVolume;
        private double _currentVolume;
        private Pump _pump;

        public WaterTower(Pump _pump, double volumeMax = 10000)
        {
            _maxVolume = volumeMax;
            this._pump = _pump;
        }

        public void PumpWater()
        {
            _pump.Enable();
            if (_currentVolume == 0)
            {
                do
                {
                    _currentVolume += _pump.PumpWaterToTower() == true ? _pump.VolumeToPump : 0;
                } while (_currentVolume < _maxVolume);
            }
            _pump.Disable();
        }

        public bool CanDistributeWater()
        {
            return _currentVolume != 0;
        }

        public abstract void DistributeWater();

        public override string? ToString()
        {
            return $"Curent water level: {_currentVolume}.\n" +
                $"Max water volume: {_maxVolume}.\n" +
                $"Pump: {_pump}.\n";
        }
    }
}
