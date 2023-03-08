using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV05
{
    internal class Osobni : Auto
    {
        public int MaxPassengers { get; private set; }
        private int _curPassengers = 0;
        public int CurPassengers
        {
            get 
            { 
                return _curPassengers; 
            }
            set
            {
                if (value > MaxPassengers)
                {
                    throw new ArgumentException("Passangers number exeeded maxPassanger value");
                }
                _curPassengers = value;
            }
        }

        public Osobni(FuelType fuelType, int tankSize, int maxPassengers) : base(fuelType, tankSize)
        {
            MaxPassengers = maxPassengers;
        }

        public override string ToString()
        {
            return string.Format(base.ToString() + "MaxPassengers: {0}\nCurPassengers: {1}\n", MaxPassengers, CurPassengers);
        }

    }
}
