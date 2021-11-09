using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    public class Square : Drawing
    {
        public double _width { get; set; }
        public double _height { get; set; }

        public Square(double Width, double Height)
        {
            this._width = Width;
            this._height = Height;
        }

        public override double Area()
        {
            double area = _width * _height;
            return area;
        }
    }
}
