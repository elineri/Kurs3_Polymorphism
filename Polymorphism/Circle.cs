using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    public class Circle : Drawing 
    {
        public double _radius { get; set; }
        public double _pi { get; set; }

        public Circle(double Radius)
        {
            this._radius = Radius;
        }

        public override double Area()
        {
            double area = _pi * (_radius * _radius);
            return area;
        }
    }
}
