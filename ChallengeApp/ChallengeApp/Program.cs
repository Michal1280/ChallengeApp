using ChallengeApp;
using System.Diagnostics;
using System.Runtime.InteropServices;
var employee = new Employee("Michal", "Tomasiuk");
Console.WriteLine("Welcome in program XYZ for marking employees");
Console.WriteLine("===========================================");
Console.WriteLine("");

while (true)
{
    Console.WriteLine("Please fill in next mark for employee.To Exit please insert 'q' ");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }
    else if ((input == "A") || (input == "a") || (input == "B") || (input == "b") || (input == "C") || (input == "c") || (input == "D") || (input == "d") || (input == "E") || (input == "e"))
    {
        char temp = char.Parse(input);
        try
        {
            employee.AddGrade(temp);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Exception catched: {ex.Message}");
        }

    }
    else
    {
        try
        {
            employee.AddGrade(input);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Exception catched: {ex.Message}");
        }
    }

}
var statistics = employee.GetStatistics();
Console.WriteLine($"This is Average value:{statistics.Average:N2}");
Console.WriteLine($"This is Min value:{statistics.Min}");
Console.WriteLine($"This is Max value: {statistics.Max}");