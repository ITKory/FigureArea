using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Circle(string name, double radius) : Shape(name)
    {
        public double Radius { get; set; } = radius;

        public override double Square()
        {
            return Math.Round(Math.PI * Math.Pow(Radius, 2), 1);
        }
    }
}
