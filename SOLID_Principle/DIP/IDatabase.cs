using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principle.DIP
{
    internal interface IDatabase
    {
        void SaveData(string data);
    }
}
