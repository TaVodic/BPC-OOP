using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV07
{
    internal abstract class Object2D : I2D, IComparable
    {
        public abstract double Area();

        public int CompareTo(object? obj)
        {
            if (obj is Object2D obj2D)
            {
                double ours = Area();
                double theirs = obj2D.Area();
                return ours.CompareTo(theirs);
            }

            throw new Exception("Incompatibile types!");
        }
    }
}
