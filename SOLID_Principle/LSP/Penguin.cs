using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principle.LSP
{
    internal class Penguin : Bird
    {
        public override void Eat()
        {
            Console.WriteLine("I am Penguin can eat..");
        }
    }
}
