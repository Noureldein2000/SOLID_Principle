// See https://aka.ms/new-console-template for more information
using SOLID_Principle;
using SOLID_Principle.ISP;
using SOLID_Principle.LSP;
using SOLID_Principle.OCP;
using SOLID_Principle.SRP;

Console.WriteLine("Hello, World for SOLID Principle!");
r: Console.WriteLine("Select from 1 to 5 to apply one of selected Solid Principle!");
var selected = Console.ReadLine();

if (string.IsNullOrEmpty(selected) || !int.TryParse(selected, out int numericValue))
{
    Console.WriteLine("Invalid Input");
    goto r;
}

if (Enum.TryParse(typeof(PrincipleEnum), selected, out var selectedEnum))
{
    PrincipleEnum principle = (PrincipleEnum)selectedEnum;

    switch (principle)
    {
        case PrincipleEnum.SRP:
            Console.WriteLine("Apply Single Reponsibility Principle  that is mean \n " +
                "\" Class shoud have only one reason to change.\"\n");
            var invoiceService = new InvoiceService(new InvoiceCalculator(), new InvoiceRepository(), new EmailService());
            invoiceService.ProcessInvoice(new Invoice());
            break;
        case PrincipleEnum.OCP:
            Console.WriteLine("Apply Open and Closed Principle that  \n " +
                "\" Open for extension and closed for modification.\"\n");
            Shape shape = new Rectangle(5, 10);
            Console.WriteLine("Area of Rectanle equal " + shape.CalculateArea());
            break;
        case PrincipleEnum.LSP:
            Console.WriteLine("Apply Liskov Substitution Principle that \n" +
                "\"Subtypes must be substitutable for their base types without altering the correctness of the program.\"\n");
            Penguin penguin = new Penguin();
            penguin.Eat();

            Sparrow sparrow = new Sparrow();
            sparrow.Eat();
            sparrow.Fly();
            break;
        case PrincipleEnum.ISP:
            Console.WriteLine("Apply Interface Segregation Principle that \n " +
                "\"Clients should not be forced to depend on interfaces they do not use\"\n");
            BasicPrinter printer = new BasicPrinter();
            printer.Print();
            MultiFunctionPrinter multiFunctionPrinter = new MultiFunctionPrinter();
            multiFunctionPrinter.Print();
            multiFunctionPrinter.Fax();
            multiFunctionPrinter.Scan();
            break;
        case PrincipleEnum.DIP:
            Console.WriteLine("Apply Dependency Inversion Principle...");
            break;

        default:
            Console.WriteLine("Invalid Input");
            goto r;
    }

    Console.WriteLine("if you want to try again for another principle, Please press yes.");
    var answer = Console.ReadLine();


    if (answer.Equals("yes", StringComparison.CurrentCultureIgnoreCase))
        goto r;
    else
        Console.WriteLine("Ok No Problem GoodBye...");

    Environment.Exit(0);

}

