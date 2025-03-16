using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principle.LSP
{
    internal class Sparrow : Bird, IFlyingBird
    {
        public override void Eat()
        {
            Console.WriteLine("I am Sparrow can eat.");
        }
        public new void Fly()
        {
            Console.WriteLine("I am Sparrow can fly.");
        }

    }
}
