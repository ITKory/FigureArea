using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Triangle : Shape
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }
        public Triangle(string name, double sideA, double sideB, double sideC) : base(name)
        {
            if ((SideA < 0 || SideB < 0 || SideC < 0))
                throw new Exception("Стороны должны быть больше 0");
            if (SideA > (SideB + SideC) || SideB > (SideA + SideC) || SideC > (SideA + SideB))
                throw new Exception("Такого треугольника не существует");

            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public override double Square()
        {
            var perimeter = (SideA + SideB + SideC) / 2; //полупериметр
            var square = Math.Sqrt(perimeter * (perimeter - SideA) * (perimeter - SideB) * (perimeter - SideC)); //формула Герона
            return square;
        }

        public bool IsStraightTriangle()
        {
            bool isStraight = (SideA == Math.Sqrt(Math.Pow(SideB, 2) + Math.Pow(SideC, 2))
                               || SideB == Math.Sqrt(Math.Pow(SideA, 2) + Math.Pow(SideC, 2))
                               || SideC == Math.Sqrt(Math.Pow(SideA, 2) + Math.Pow(SideC, 2)));

            return isStraight;
        }
    }
}
