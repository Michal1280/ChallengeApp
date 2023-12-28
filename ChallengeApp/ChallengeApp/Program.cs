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
    } else if ((input == "A")||(input == "a")||(input == "B")||(input == "b")||(input == "C")||(input == "c")||(input == "D")||(input == "d")||(input == "E")||(input == "e"))
    {
       char temp = char.Parse(input);
        employee.AddGrade(temp);
    }else
    {
        employee.AddGrade(input);
    }
   
}
var statistics = employee.GetStatistics();
Console.WriteLine($"This is Average value:{statistics.Average}");
Console.WriteLine($"This is Min value:{statistics.Min}");
Console.WriteLine($"This is Max value: {statistics.Max}");