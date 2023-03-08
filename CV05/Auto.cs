using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV05
{
    internal class Auto
    {
        public enum FuelType
        {
            gasoline,
            diesel
        }

        public FuelType Fuel { get; set; }

        public int FuelTankSize { get; protected set; }

        protected int FuelLevel;

        private CarRadio carRadio;

        protected Auto(FuelType fuel, int tankSize)
        {
            FuelTankSize = tankSize;
            this.Fuel = fuel;
            FuelLevel = 0;
            carRadio = new CarRadio();
        }

        public void fillTank(FuelType fuel, int fuelAmount)
        {
            if (fuel != this.Fuel)
            {
                throw new Exception("Wrong fule type");
            }
           if (FuelLevel+fuelAmount > FuelTankSize)
            {
                throw new Exception("Too much fuel");
            }
            FuelLevel += fuelAmount;
        }

        public void createPreset(int num, double freq)
        {
            carRadio.createPreset(num, freq);
        }

        public void setPreset(int num)
        {
            carRadio.setPreset(num);
        }

        public override string ToString()
        {
            return $"Max tank size: {FuelTankSize}\nFuel level: {FuelLevel}\nradio frequency: {carRadio.frequency}MHz\nisRadioON? {carRadio.isRadioOn}\n";
        }
    }
}

/*private readonly Dictionary<string, int> keyValuePairs = new Dictionary<string, int>()
{
{"key", value}
}*/