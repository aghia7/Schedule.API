using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Schedule.API.Models
{
    public abstract class Shape
    {
        public string Name { get; }

        public Shape(string name)
        {
            Name = name;
        }

        public Shape(int name)
        {
            Name = name + " ";
        }

        public virtual double Area() { return 0; }

        public override string ToString()
        {
            return $"{Name} {Area()}";
        }

    }
}
