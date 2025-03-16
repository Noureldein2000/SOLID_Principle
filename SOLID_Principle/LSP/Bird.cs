using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principle.LSP
{
    internal abstract class Bird
    {
        //---------------------------- Violating LSP -------------------------------
        //public void Fly()
        //{
        //    Console.WriteLine("I can fly!");
        //}
        //because not all the birds can fly even it belongs to bird category

        //---------------------------- Applying LSP (Refactored) -------------------------------
       public abstract void Eat();
    }
}
