using System.Net.Http.Headers;
using System.Net.WebSockets;
using Wyzwanie21;

var employee = new Employee("Roman", "Romanski");
employee.AddGrade(4);
employee.AddGrade(7);
employee.AddGrade(5);
var statisticks = employee.GetStatisticks();

Console.WriteLine($"Average: {statisticks.Average:N2}");
Console.WriteLine($"Max: {statisticks.Max:N2}");
Console.WriteLine($"Min: {statisticks.Min:N2}");

SetSth(out statisticks);
void SetSth(out Statisticks statisticks)
{
    statisticks = new Statisticks();

}