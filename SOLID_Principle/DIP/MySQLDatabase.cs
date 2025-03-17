using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principle.DIP
{
    public class MySQLDatabase : IDatabase
    {
        public void SaveData(string data)
        {
            Console.WriteLine($"Saving data to MySQL: {data}");
        }
    }
}
