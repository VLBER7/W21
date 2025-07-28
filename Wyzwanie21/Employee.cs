namespace Wyzwanie21
{
    public class Employee : Person
    {
        private List<float> grades = new List<float>();

        public Employee(string name, string surname, string sex)
            : base(name, surname, sex)
        {
        }

        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                Console.WriteLine($"Ocena musi byc w zakresie od 0 do 100, a twoja to {grade}.");
            }
        }

        public void AddGrade(char grade)
        {
            switch (char.ToUpper(grade))
            {
                case 'A':
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

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            if (this.grades.Any())
            {
                statistics.Average = this.grades.Average();
                statistics.Max = this.grades.Max();
                statistics.Min = this.grades.Min();
            }

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

        public string GetAllGradesFormatted()
        {
            return string.Join(", ", this.grades);
        }
    }
}