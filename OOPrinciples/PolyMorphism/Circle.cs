﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyMorphism
{
    class Circle : Shape
    {
        //property only available to the circle
        public decimal Radius { get; set; }

        public override string Draw()
        {
            return "Drawing a Circle";
        }

    }
}
