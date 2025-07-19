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
        public void AddGrade(decimal grade)
        {
            float ValueInFloat = (float)grade;
            this.AddGrade(ValueInFloat);
        }
        public void AddGrade(double grade)
        {
           float ValueInFloat = (float)grade;
           this.AddGrade(ValueInFloat);
        }
        public void AddGrade(int grade)
        {
            float ValueInFloat = (float)grade;
            this.AddGrade(ValueInFloat);
        
        }
        public Statisticks GetStatisticks()
        {
            var statisticks = new Statisticks();
            statisticks.Average = 0;
            statisticks.Max = float.MinValue;
            statisticks.Min = float.MaxValue;

            List<string> formattedGrades = new List<string>();
            foreach (var grade in this.grades)
            //break
            //continue
            //goto

            {
                if (grade >= 0 && grade <= 100)
                {
                    statisticks.Max = Math.Max(statisticks.Max, grade);
                    statisticks.Min = Math.Min(statisticks.Min, grade);
                    statisticks.Average += grade;
                }
                formattedGrades.Add(grade.ToString());
            }

            if (this.grades.Count > 0)
            {
                statisticks.Average /= this.grades.Count;
            }
            else
            {
                statisticks.Average = 0;
            }

            Console.Write("Wszystkie oceny to: ");
            Console.WriteLine(string.Join(", ", formattedGrades));

            return statisticks;
        }
        public Statisticks GetStatisticksWithForEach()
        {
            var statisticks = new Statisticks();
            statisticks.Average = 0;
            if (this.grades.Count == 0)
            {
                Console.WriteLine("Brak ocen do obliczen.");
                statisticks.Max = float.MinValue;
                statisticks.Min = float.MaxValue;
                return statisticks;
            }
            float? firstValidGrade = null;
            foreach (var X in this.grades)
            {
                if (X >= 0 && X <= 5)
                {
                    statisticks.Max = X;
                    statisticks.Min = X;
                    firstValidGrade = X;
                    break;
                }
            }
            if (!firstValidGrade.HasValue)
            { Console.WriteLine("Brak ocen z zakresu 0-5."); return statisticks; }
            
            int validGradesCount = 0;
            Console.WriteLine("Wyniki dla petli foreach z zakresu 0-5:");
            foreach (var grade in this.grades)
            {
                if (grade >=0 && grade <= 5) 
                {
                    statisticks.Max = Math.Max(statisticks.Max, grade);
                    statisticks.Min = Math.Min(statisticks.Min, grade);
                    statisticks.Average += grade;
                    validGradesCount++; 
                    Console.WriteLine($"{grade}"); 
                }
            
            }
            return statisticks;
        }
        public Statisticks GetStatisticksWithFor()
        {
            var statisticks = new Statisticks();

            if (this.grades.Count == 0)
            {
                Console.WriteLine("Brak ocen do obliczen.");
                statisticks.Average = 0;
                statisticks.Max = float.MinValue;
                statisticks.Min = float.MaxValue;
                return statisticks;
            }

            statisticks.Average = 0;
            statisticks.Max = float.MinValue;
            statisticks.Min = float.MaxValue;

            for (int i = 0; i < this.grades.Count; i++ )
            {
                float grade = this.grades[i];
                statisticks.Max = Math.Max(statisticks.Max, grade);
                statisticks.Min = Math.Min(statisticks.Min, grade);
                statisticks.Average += grade;
            }

            statisticks.Average /= this.grades.Count;
            Console.WriteLine($"Wyniki dla petli for:");
            Console.WriteLine($"Srednia: {statisticks.Average:N2}");
            Console.WriteLine($"Maksymalna: {statisticks.Max}");
            Console.WriteLine($"Minimalna: {statisticks.Min}");

            return statisticks;
        }
        public Statisticks GetStatisticksWithWhile()
        {
            var statisticks = new Statisticks();
            statisticks.Average = 0;
            statisticks.Max = float.MinValue;
            statisticks.Min = float.MaxValue;
            int i = 0;
            while (i < this.grades.Count)
            {
                if (this.grades[i] <= 0 || this.grades[i] >= 100)
                {
                    statisticks.Max = Math.Max(statisticks.Max, this.grades[i]);
                    statisticks.Min = Math.Min(statisticks.Min, this.grades[i]);
                    statisticks.Average += this.grades[i];
                }
                Console.WriteLine($"Pętla WithWile czyli wszystko od 0 do 100: {this.grades[i]}");
                i++;
            }
            statisticks.Average /= this.grades.Count;
            return statisticks;
        }
    }
}
    

