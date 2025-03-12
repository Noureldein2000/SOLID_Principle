// See https://aka.ms/new-console-template for more information
using SOLID_Principle;

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
                "\" Class shoud have only one reason to change.\"");
            break;
        case PrincipleEnum.OCP:
            Console.WriteLine("Apply Open and Closed Principle that  \n " +
                "\" Open for extension and closed for modification.\"");
            break;
        case PrincipleEnum.LSP:
            Console.WriteLine("Apply Liskov Substitution Principle that \n" +
                "\"Subtypes must be substitutable for their base types without altering the correctness of the program.\"");
            break;
        case PrincipleEnum.ISP:
            Console.WriteLine("Apply Interface segregation Principle..");
            break;
        case PrincipleEnum.DIP:
            Console.WriteLine("Apply Dependency inversion Principle..");
            break;

        default:
            Console.WriteLine("Invalid Input");
            goto r;
    }

    Console.WriteLine("if you want to try again for another principle, Please press yes.");
    var answer = Console.ReadLine();


    if (answer.ToLower() == "yes".ToLower())
        goto r;
    else
        Console.WriteLine("Ok No Problem GoodBye...");
    
    Environment.Exit(0);

}

