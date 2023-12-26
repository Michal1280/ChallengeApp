﻿using ChallengeApp;
using System.Runtime.InteropServices;
var employee = new Employee("Michal", "Tomasiuk");
employee.AddGrade("Michal");
employee.AddGrade("2");
employee.AddGrade(2);
employee.AddGrade(200);
employee.AddGrade(6);
employee.AddGrade(6.66);
employee.AddGrade(96.55);
var statistics = employee.GetStatistics();
Console.WriteLine($"This is Max Value: {statistics.Max}");
Console.WriteLine($"This is Min Value: {statistics.Min}");
Console.WriteLine($"This is Average Value: {statistics.Average:N2}");