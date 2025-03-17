using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principle.ISP
{
    internal class BasicPrinter : IPrinter //IMachine
    {
        public void Print()
        {
            Console.WriteLine("Basic Printing only from IPrinter interface... \n");
        }

        //-------------- Violating ISP --------------------
        //public void Scan()
        //{
        //    throw new NotImplementedException("Scan not supported!");
        //}

        //public void Fax()
        //{
        //    throw new NotImplementedException("Fax not supported!");
        //}
    }
}
