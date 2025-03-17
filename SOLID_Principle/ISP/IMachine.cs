using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principle.ISP
{
    internal interface IMachine
    {
        //Violating ISP beacause not all machine doing of these methods
        //need to split this fat interface into too many picese
        void Print();
        void Scan();
        void Fax();
    }
}
