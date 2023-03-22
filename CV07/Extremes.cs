using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV07
{
    internal static class Extremes
    {
        public static T Max<T>(IEnumerable<T> objects) where T : IComparable
        {
            if (objects == null) throw new ArgumentNullException(nameof(objects));

            return objects.Max();
        }

        public static T Min<T>(IEnumerable<T> objects) where T : IComparable
        {
            return objects.Min();
        }
    }
}
