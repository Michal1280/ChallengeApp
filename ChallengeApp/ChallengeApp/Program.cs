using ChallengeApp;
using System.Diagnostics;
using System.Runtime.InteropServices;
var employee = new EmployeeInFile("Michal", "Tomasiuk");
Console.WriteLine("Welcome in program XYZ for marking employees");
Console.WriteLine("===========================================");
Console.WriteLine("");
try
{
    employee.AddGrade(10);
}
catch (Exception ex)
{
    Console.WriteLine($"Exception catched: {ex.Message}");
}
try
{
    employee.AddGrade(20);
}
catch (Exception ex)
{
    Console.WriteLine($"Exception catched: {ex.Message}");
}
try
{
    employee.AddGrade(30);
}
catch (Exception ex)
{
    Console.WriteLine($"Exception catched: {ex.Message}");
}

try
{
    employee.AddGrade('e');
}
catch (Exception ex)
{
    Console.WriteLine($"Exception catched: {ex.Message}");
}

try
{
    employee.AddGrade('b');
}
catch (Exception ex)
{
    Console.WriteLine($"Exception catched: {ex.Message}");
}
try
{
    employee.AddGrade(101);
}
catch (Exception ex)
{
    Console.WriteLine($"Exception catched: {ex.Message}");
}
try
{
    employee.AddGrade(-200);
}
catch (Exception ex)
{
    Console.WriteLine($"Exception catched: {ex.Message}");
}

//while (true)
//{
//    Console.WriteLine("Please fill in next mark for employee.To Exit please insert 'q' ");
//    var input = Console.ReadLine();
//    if (input == "q")
//    {
//        break;
//    }
//    else if ((input == "A") || (input == "a") || (input == "B") || (input == "b") || (input == "C") || (input == "c") || (input == "D") || (input == "d") || (input == "E") || (input == "e"))
//    {
//        char temp = char.Parse(input);
//        try
//        {
//            employee.AddGrade(temp);
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine($"Exception catched: {ex.Message}");
//        }

//    }
//    else
//    {
//        try
//        {
//            employee.AddGrade(input);
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine($"Exception catched: {ex.Message}");
//        }
//    }

//}
//var statistics = employee.GetStatistics();
//Console.WriteLine($"This is Average value:{statistics.Average:N2}");
//Console.WriteLine($"This is Min value:{statistics.Min}");
//Console.WriteLine($"This is Max value: {statistics.Max}");
var result = employee.GetStatistics();
Console.WriteLine($"Max value is: {result.Max}");
Console.WriteLine($"Min value is: {result.Min}");
Console.WriteLine($"Average value is: {result.Average}");
Console.WriteLine($"Average value in latter is: {result.AverageLetter}");