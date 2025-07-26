using System;
using Wyzwanie21;

Console.WriteLine("Witam serdecznie w programie oceny pracowników");
Console.WriteLine("==========================================================");
Console.WriteLine();

var employee = new Employee("Roman", "Romanski");


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

    try
    {
        if (float.TryParse(input, out float nrGrade))
        {
            employee.AddGrade(nrGrade);
        }
        else if (input.Length == 1)
        {
            char charGrade = input[0];
            employee.AddGrade(charGrade);
        }
        else
        {
            Console.WriteLine($"Nieznany format oceny '{input}'. Wpisz liczbę lub literę A-E.");
        }
    }
    catch (Exception e)
    {
        Console.WriteLine($"Wyjątek CATCH: {e.Message}");
    }
}

Console.Write("Wszystkie oceny to: ");
Console.WriteLine(employee.GetAllGradesFormatted());

var statistics = employee.GetStatistics();
Console.WriteLine($"Statystyki dla pracownika {employee.Name} {employee.Surname}:");
Console.WriteLine($"Minimalna ocena: {statistics.Min}");
Console.WriteLine($"Maksymalna ocena: {statistics.Max}");
Console.WriteLine($"Srednia z ocen: {statistics.Average}");
Console.WriteLine($"Ocena literowa: {statistics.AverageLetter}");