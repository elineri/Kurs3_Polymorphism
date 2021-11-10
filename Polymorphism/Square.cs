using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    public class Square : Drawing
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Square()
        {
            Width = 4.3;
            Height = 5.9;
        }

        public override double Area()
        {
            double area = Width * Height;

            Console.Write("Fyrkantens area: ");
            return area;
        }
    }
}
