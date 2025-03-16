using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principle.OCP
{
    internal class Triangle : Shape
    {
        public int Height { get; set; }
        public int BaseLength { get; set; }
        public override double CalculateArea()
        {
            return 0.5 * Height * BaseLength;
        }
    }
}
