using System.Security.AccessControl;

namespace Wyzwanie21
{
    public class Employee
    {
        private List<float> grades = new List<float>();

        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }

        public void AddGrade(float grade)
        {
            int ValueInInt = (int)grade;
            float f = ValueInInt;

            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                Console.WriteLine($"Ocena musi byc w zakresie od 0 do 100, a twoja to {grade}.");
            }
        }
        public void AddGrade(string grade)
        {

            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                Console.WriteLine($"String, to nie float - zmien swoja ocene z '{grade}' na jakas cyfre lub wartosc liczbowa!");
            }
        }

        public void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A':
                case 'a':
                    this.grades.Add(100);
                    break;

                case 'B':
                    this.grades.Add(80);
                    break;

                case 'C':
                    this.grades.Add(60);
                    break;

                case 'D':
                    this.grades.Add(40);
                    break;

                case 'E':
                    this.grades.Add(20);
                    break;
                default:
                    Console.WriteLine($"Nieznana ocena: {grade}, wpisz ocene A / B / C / D / E");
                    break;
            }
        }

        public Statistics GetStatisticks()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            List<string> formattedGrades = new List<string>();
            foreach (var grade in this.grades)

            {
                if (grade >= 0 && grade <= 100)
                {
                    statistics.Max = Math.Max(statistics.Max, grade);
                    statistics.Min = Math.Min(statistics.Min, grade);
                    statistics.Average += grade;
                }
                formattedGrades.Add(grade.ToString());
            }

            if (this.grades.Count > 0)
            {
                statistics.Average /= this.grades.Count;
            }
            else
            {
                statistics.Average = 0;
            }

            Console.Write("Wszystkie oceny to: ");
            Console.WriteLine(string.Join(", ", formattedGrades));


            switch (statistics.Average)
            {
                case var a when a >= 80:
                    statistics.AverageLetter = 'A';
                    break;
                case var a when a >= 60:
                    statistics.AverageLetter = 'B';
                    break;
                case var a when a >= 40:
                    statistics.AverageLetter = 'C';
                    break;
                case var a when a >= 20:
                    statistics.AverageLetter = 'D';
                    break;
                default:
                    statistics.AverageLetter = 'E';
                    break;
            }

            return statistics;
        }
    }
}