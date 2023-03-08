using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV05
{
    internal class Nakladni : Auto
    {
        public int MaxCargo { get; private set; }
        private int _curCargo = 0;
        public int CurCargo
        {
            get
            {
                return _curCargo;
            }
            set
            {
                if (value > MaxCargo)
                {
                    throw new ArgumentException("Cargo number exeeded MaxCargo value");
                }
                _curCargo = value;
            }
        }

        public Nakladni(FuelType fuelType, int tankSize, int maxCargo) : base(fuelType, tankSize)
        {
            MaxCargo = maxCargo;
        }

        public override string ToString()
        {
            return string.Format(base.ToString() + "MaxCargo: {0}\nCurCargo: {1}\n", MaxCargo, CurCargo);
        }
    }
}
