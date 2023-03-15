 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV06
{
    internal abstract class Object3D : GrObject
    {
        abstract public double CalcSurface();
        abstract public double CalcVolume();
    }
}
