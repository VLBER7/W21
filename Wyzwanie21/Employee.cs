namespace Wyzwanie21
{
    public class Employee : Person
    {
        private List<float> grades = new List<float>();

        public Employee(string name, string surname, string sex)
            : base(name, surname, sex)
        {
        }

        public bool AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool AddGrade(char grade)
        {
            switch (char.ToUpper(grade))
            {
                case 'A':
                    this.grades.Add(100);
                    return true;
                case 'B':
                    this.grades.Add(80);
                    return true;
                case 'C':
                    this.grades.Add(60);
                    return true;
                case 'D':
                    this.grades.Add(40);
                    return true;
                case 'E':
                    this.grades.Add(20);
                    return true;
                default:
                    return false;
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