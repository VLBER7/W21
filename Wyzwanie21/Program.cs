using System.Net.Http.Headers;
using System.Net.WebSockets;
using Wyzwanie21;

var employee = new Employee("Roman", "Romanski");
employee.AddGrade("2");
employee.AddGrade(7);
employee.AddGrade(5);
employee.AddGrade("maselko");
employee.AddGrade(55);
employee.AddGrade(99);
employee.AddGrade(4.99999f);
employee.AddGrade(561);
employee.AddGrade(4.5f);
employee.AddGrade(6.99f);
employee.AddGrade(5.55555555555f);
employee.AddGrade(5.55555555555f);
employee.AddGrade(4);
employee.AddGrade(101);

var statisticks = employee.GetStatisticks();
