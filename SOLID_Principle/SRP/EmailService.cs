using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principle.SRP
{
    internal class EmailService
    {
        public void SendEmailNotification(Invoice invoice)
        {
            // Logic to send email notification
            Console.WriteLine("Send Invoices Email to Users from EmailService \n");

        }
    }
}
