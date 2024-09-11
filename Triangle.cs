﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shape
{
    // Clase Triangle que implementa CalculateSurface
    public class Triangle : Shape
    {
        public Triangle(double width, double height) : base(width, height) { }

        public override double CalculateSurface()
        {
            return (Width * Height) / 2;
        }
    }
}
