using System.Net.Http.Headers;
using System.Net.WebSockets;
using Wyzwanie21;

var employee = new Employee("Roman", "Romanski");
employee.AddGrade("2");
employee.AddGrade(7);
employee.AddGrade(5);
employee.AddGrade("maselko");
employee.AddGrade(5555);
employee.AddGrade(4.5f);
employee.AddGrade(6.99f);
employee.AddGrade(5.55555555555);
employee.AddGrade(4);
employee.AddGrade(101);
var statisticks = employee.GetStatisticks();
var statisticks1 = employee.GetStatisticksWithForEach();
var statisticks2 = employee.GetStatisticksWithFor();
var statisticks3 = employee.GetStatisticksWithDoWhile();
var statisticks4 = employee.GetStatisticksWithWhile();

//Console.WriteLine($"Average: {statisticks.Average:N2}");
//Console.WriteLine($"Max: {statisticks.Max:N2}");
//Console.WriteLine($"Min: {statisticks.Min:N2}");

//SetSth(out statisticks);
//void SetSth(out Statisticks statisticks)
//{
//    statisticks = new Statisticks();
//}