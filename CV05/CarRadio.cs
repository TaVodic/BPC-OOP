using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV05
{
    internal class CarRadio
    {
        public double frequency;
        public bool isRadioOn;
        private Dictionary<int, double> _preset = new Dictionary<int, double>();

        public void createPreset(int number, double frequency)
        {            
            isRadioOn = true;
            _preset.Add(number, frequency);
        }

        public void setPreset(int number)
        {
            this.frequency = _preset[number];
        }
    }
}
