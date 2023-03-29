using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV08
{
    internal class YearTemp
    {
        public int year;
        public List<double> monthTemp;

        public YearTemp(List<double> mt, int year)
        {
            monthTemp = mt;
            this.year = year;
        }

        public double GetMaxTemp()
        {
            return monthTemp.Max();
        }

        public double GetMinTemp()
        {
            return monthTemp.Min();
        }

        public double GetAvgTemp()
        {
            return monthTemp.Average();
        }


    }
}
