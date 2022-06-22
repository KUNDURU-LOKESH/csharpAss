// See https://aka.ms/new-console-template for more information
using ConsoleOrg;

Actions actions = new Actions();

Console.WriteLine("..............Select your choice.............");
Console.WriteLine("Press 1 for add");
Console.WriteLine("Press 2 for show");
Console.WriteLine("Press 3 for Update");
Console.WriteLine("Press 4 delete");
int choice = Convert.ToInt32(Console.ReadLine());
var result = string.Empty;
switch (choice)
{
    case 1:
        result =  actions.Add();
        Console.WriteLine(result);
        break;
    case 2:
        actions.Show();
        break;
    case 3:
        result = actions.Update();
        Console.WriteLine(result);
        break;
    case 4:
        result = actions.Delete();
        Console.WriteLine(result);
        break;
    default:
        break;
}

Console.ReadLine();
