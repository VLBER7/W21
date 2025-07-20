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

            return statistics;
        }
    }
}