using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principle.SRP
{
    internal class InvoiceRepository
    {
        public void SaveToDatabase(Invoice invoice)
        {
            // Logic to save invoice to database
            Console.WriteLine("insert into database record table from reporsitory \n");

        }
    }
}
