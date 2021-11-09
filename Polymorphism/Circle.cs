using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    public class Circle : Drawing 
    {
        public double Radius { get; set; }
        public double Pi { get; set; }

        public Circle()
        {
            Radius = 5.67;
            Pi = 3.14159265359;
        }

        public override double Area()
        {
            double area = Pi * (Radius * Radius);

            Console.WriteLine("Cirkelns area är :" + area);

            return area;
        }
    }
}
