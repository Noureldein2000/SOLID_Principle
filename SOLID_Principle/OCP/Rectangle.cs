using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principle.OCP
{
    internal class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public Rectangle(double heigth, double width)
        {
            Width = width;
            Height = heigth;
        }
        public override double CalculateArea()
        {
            return Width * Height;
        }
    }
}
