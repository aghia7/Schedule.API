using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Schedule.API.Models
{
    public class Circle : Shape
    {
        public double Radius { get; set; }
        public Circle(string name, double radius) : base(name)
        {
            Radius = radius;
        }

        public double Area()
        {
            return Math.PI * Math.Pow(Radius, 2.0);
        }

    }
}
