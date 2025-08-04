namespace Wyzwanie21
{
    class Supervisor : Person, iEmployee
    {
        private List<float> grades = new List<float>();

        public Supervisor(string name, string surname, string sex) : base(name, surname, sex)
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
                Console.WriteLine($"Ocena którą podałeś: {grade} jest błędna - zakres ocen to 0-100 lub oceny szkolne!");
            }
        }

        public void AddGrade(string grade)
        {
            switch (grade)
            {
                case "6":
                    this.AddGrade(100);
                    return;
                case "6-":
                    this.AddGrade(95);
                    return;
                case "5+":
                    this.AddGrade(85);
                    return;
                case "5":
                    this.AddGrade(80);
                    return;
                case "5-":
                    this.AddGrade(75);
                    return;
                case "4+":
                    this.AddGrade(65);
                    return;
                case "4":
                    this.AddGrade(60);
                    return;
                case "4-":
                    this.AddGrade(55);
                    return;
                case "3+":
                    this.AddGrade(45);
                    return;
                case "3":
                    this.AddGrade(40);
                    return;
                case "3-":
                    this.AddGrade(35);
                    return;
                case "2+":
                    this.AddGrade(25);
                    return;
                case "2":
                    this.AddGrade(20);
                    return;
                case "2-":
                    this.AddGrade(15);
                    return;
            }

            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else if (grade.Length == 1 && char.IsLetter(grade[0]))
            {
                this.AddGrade(char.ToUpper(grade[0]));
            }
            else
            {
                throw new ArgumentException($"Nieprawidłowy format oceny: '{grade}'.");
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
            statistics.AverageNumericString = "0";

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

            if (this.grades.Any())
            {
                if (statistics.Average >= 90)
                {
                    statistics.AverageNumericString = "6";
                }
                else if (statistics.Average >= 70)
                {
                    statistics.AverageNumericString = "5";
                }
                else if (statistics.Average >= 50)
                {
                    statistics.AverageNumericString = "4";
                }
                else if (statistics.Average >= 30)
                {
                    statistics.AverageNumericString = "3";
                }
                else if (statistics.Average >= 10)
                {
                    statistics.AverageNumericString = "2";
                }
                else
                {
                    statistics.AverageNumericString = "1";
                }
            }
            else
            {
                statistics.AverageNumericString = "Brak";
            }

            return statistics;
        }

        public string GetAllGradesFormatted()
        {
            return string.Join(", ", this.grades);
        }
    }
}