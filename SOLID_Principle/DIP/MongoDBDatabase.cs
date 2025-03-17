using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principle.DIP
{
    internal class MongoDBDatabase : IDatabase
    {
        public void SaveData(string data)
        {
            Console.WriteLine($"Saving data to MongoDB: {data}");
        }
    }
}
