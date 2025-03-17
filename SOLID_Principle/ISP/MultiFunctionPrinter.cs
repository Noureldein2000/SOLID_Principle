using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principle.ISP
{
    internal class MultiFunctionPrinter : IPrinter, IScanner, IFaxer
    {
        public void Print()
        {
            Console.WriteLine("Printing from IPrinter interface...\n");
        }

        public void Scan()
        {
            Console.WriteLine("Scanning from IScanner interface...\n");
        }

        public void Fax()
        {
            Console.WriteLine("Faxing from IFaxer interfacer...\n");
        }
    }
}
