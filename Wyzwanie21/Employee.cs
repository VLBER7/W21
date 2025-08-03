namespace Wyzwanie21
{
    public class Employee : iEmployee
    {
        private List<float> grades = new List<float>();

        public Employee(string name, string surname, string sex)
        {
            this.Name = name;
            this.Surname = surname;
            this.Sex = sex;
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string Sex { get; private set; }

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
            statistics.Max = 0;
            statistics.Min = 0;

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
                case var a when a > 0:
                    statistics.AverageLetter = 'E';
                    break;
                default:
                    statistics.AverageLetter = '0';
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