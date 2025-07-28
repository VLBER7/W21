using System;
using Wyzwanie21;

Console.WriteLine("Witam serdecznie w programie oceny pracowników");
Console.WriteLine("==========================================================");
Console.WriteLine();

var employee = new Employee("Roman", "Romanski", "M");

while (true)
{
    Console.WriteLine("Podaj ocenę dla pracownika (liczba od 0 do 100, lub litera A-E). Aby zakończyć, wpisz 'q'.");
    var input = Console.ReadLine();

    if (input == "q")
    {
        break;
    }

    if (string.IsNullOrWhiteSpace(input))
    {
        Console.WriteLine("Nie podano żadnej oceny. Spróbuj ponownie.");
        continue;
    }

    bool gradeAdded = false;

    if (float.TryParse(input, out float nrGrade))
    {
        gradeAdded = employee.AddGrade(nrGrade);
        if (!gradeAdded)
        {
            Console.WriteLine($"Ocena musi być w zakresie od 0 do 100, a twoja to {nrGrade}.");
        }
    }
    else if (input.Length == 1)
    {
        char charGrade = input[0];
        gradeAdded = employee.AddGrade(charGrade);
        if (!gradeAdded)
        {
            Console.WriteLine($"Nieznana ocena: {charGrade}. Wpisz ocenę A / B / C / D / E.");
        }
    }
    else
    {
        Console.WriteLine($"Nieznany format oceny '{input}'. Wpisz liczbę lub literę A-E.");
    }
}

Console.Write("Wszystkie oceny to: ");
Console.WriteLine(employee.GetAllGradesFormatted());

var statistics = employee.GetStatistics();
Console.WriteLine($"Statystyki dla pracownika o imieniu: {employee.Name}, nazwisku: {employee.Surname} oraz zadeklarowanej płci: {employee.Sex}");
Console.WriteLine($"Minimalna ocena: {statistics.Min}");
Console.WriteLine($"Maksymalna ocena: {statistics.Max}");
Console.WriteLine($"Srednia z ocen: {statistics.Average}");
Console.WriteLine($"Ocena literowa: {statistics.AverageLetter}");