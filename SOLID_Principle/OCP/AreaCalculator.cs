using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principle.OCP
{
    internal class AreaCalculator
    {
        //---------------------------- Violating  OCP  -------------------------------
        public double CalculateArea(object shape)
        {
            if (shape is Rectangle rectangle)
            {
                return rectangle.Width * rectangle.Height;
            }
            else if (shape is Circle circle)
            {
                return Math.PI * circle.Radius * circle.Radius;
            }
            else if (shape is Triangle triangle)
            {
                return 0.5 * triangle.Height * triangle.BaseLength;
            }
            return 0;
        }
        //---------------------------- Applying OCP (Refactored) -------------------------------

        public double CalculateArea(Shape shape)
        {
            return shape.CalculateArea();
        }
    }
}
