using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyMorphism
{
    public class Shape
    {
        //virtual = this is a method that CAN be overriden by the derived class

        public virtual string Draw()
        {
            return "Drawing a shape";
        }
    }
}
