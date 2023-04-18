using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal abstract class Pump
    {
        public double Power { get; private set; }
        public double Speed { get; private set; }
        public double VolumeToPump { get; }

        private bool Enabled { get; set; }

        public Pump(double volumeToPump=10000, double power = 20, double speed = 20)
        {
            Power = power;
            Speed = speed;
            VolumeToPump = volumeToPump;
        }
        public void Enable()
        {
            Enabled = true;
        }

        public void Disable()
        {
            Enabled = false;
        }
        public bool CanPump()
        {
            return Enabled;
        }

        public bool PumpWaterToTower()
        {
            if (CanPump())
            {
                PumpWaterWithSpecificSpeed(VolumeToPump);
                return true;
            }
            return false;
        }
        public abstract bool PumpWaterWithSpecificSpeed(double volumeToPump);

        public override string? ToString()
        {
            return $"Water pump with power:{Power} and pump speed:{Speed} is now Enabled:{Enabled}";
        }
    }
}
