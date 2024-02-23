using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public abstract class Shape
    {
        public string Name { get; set; }
        protected Shape(string name)
        {
            Name = name;
        }
        public abstract double Square();
        public override string ToString()
        {
            return $"Текущий тип фигуры: " + Name;
        }
    }
}
