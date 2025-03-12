using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principle.SRP
{
    internal class InvoiceService
    {
        //--------------------------- Violating SRP ------------------------------
        public void CalculateTotal(Invoice invoice)
        {
            // Logic to calculate total
            Console.WriteLine("Calculate the invoice's price");
        }

        public void SaveToDatabase(Invoice invoice)
        {
            // Logic to save invoice to database
            Console.WriteLine("insert into database record table");
        }

        public void SendEmailNotification(Invoice invoice)
        {
            // Logic to send email notification
            Console.WriteLine("Send Invoices Email to Users");
        }

        //---------------------------- Applying SRP (Refactored) -------------------------------


        private readonly InvoiceCalculator _calculator;
        private readonly InvoiceRepository _repository;
        private readonly EmailService _emailService;

        public InvoiceService(InvoiceCalculator calculator, InvoiceRepository repository, EmailService emailService)
        {
            _calculator = calculator;
            _repository = repository;
            _emailService = emailService;
        }

        public void ProcessInvoice(Invoice invoice)
        {
            _calculator.CalculateTotal(invoice);
            _repository.SaveToDatabase(invoice);
            _emailService.SendEmailNotification(invoice);
        }
    }
}
