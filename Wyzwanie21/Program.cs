using System.Net.Http.Headers;
using System.Net.WebSockets;
using Wyzwanie21;

var employee = new Employee("Roman", "Romanski");
employee.AddGrade(70);
employee.AddGrade(55);
employee.AddGrade(20);
var statisticks = employee.GetStatisticks();
Console.WriteLine(statisticks.AverageLetter);
