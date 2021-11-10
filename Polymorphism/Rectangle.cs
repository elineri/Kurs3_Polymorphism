using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    public class Rectangle : Drawing
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle()
        {
            Width = 3.2;
            Height = 7.1;
        }

        public override double Area()
        {
            double area = Width * Height;

            Console.Write("Rektangelns area: ");
            return area;
        }
    }
}
