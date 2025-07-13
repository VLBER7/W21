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
                Console.WriteLine("Grade must be between 0 and 100."); 
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
                Console.WriteLine("String is not float.");
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


            foreach (var grade in this.grades)
            //break
            //continue
            //goto
            {
                if (grade >= 0)
                {
                    statisticks.Max = Math.Max(statisticks.Max, grade);
                    statisticks.Min = Math.Min(statisticks.Min, grade);
                    statisticks.Average += grade;
                }
                Console.WriteLine($"Grade basic: {grade}");
            }
            statisticks.Average = statisticks.Average /= this.grades.Count;
            return statisticks;
        }
        public Statisticks GetStatisticksWithForEach()
        {
            var statisticks = new Statisticks();
            statisticks.Average = 0;
            statisticks.Max = float.MinValue;
            statisticks.Min = float.MaxValue;
            foreach (var grade in this.grades)
            {
                if (grade >= 0)
                {
                    statisticks.Max = Math.Max(statisticks.Max, grade);
                    statisticks.Min = Math.Min(statisticks.Min, grade);
                    statisticks.Average += grade;
                }
                Console.WriteLine($"Grade with foreach: {grade}");
            }
            statisticks.Average /= this.grades.Count;
            return statisticks;
        }
        public Statisticks GetStatisticksWithFor()
        {
            var statisticks = new Statisticks();

            if (this.grades.Count == 0)
            {
                Console.WriteLine("Brak ocen do obliczeń.");
                statisticks.Average = 0;
                statisticks.Max = float.MinValue;
                statisticks.Min = float.MaxValue;
                return statisticks;
            }

            statisticks.Average = 0;
            statisticks.Max = float.MinValue;
            statisticks.Min = float.MaxValue;

            for (int i = 0; i < this.grades.Count; i++)
            {
                float grade = this.grades[i];
                statisticks.Max = Math.Max(statisticks.Max, grade);
                statisticks.Min = Math.Min(statisticks.Min, grade);
                statisticks.Average += grade;
            }

            statisticks.Average /= this.grades.Count;

            // Po wyjściu z pętli wyświetlaj wyniki
            Console.WriteLine($"--- Wyniki dla pętli 'for' ---");
            Console.WriteLine($"Średnia: {statisticks.Average:N2}");
            Console.WriteLine($"Maksymalna: {statisticks.Max}");
            Console.WriteLine($"Minimalna: {statisticks.Min}");
            Console.WriteLine($"------------------------------");

            return statisticks;
        }
        public Statisticks GetStatisticksWithDoWhile()
        {
            var statisticks = new Statisticks();
            statisticks.Average = 0;
            statisticks.Max = float.MinValue;
            statisticks.Min = float.MaxValue;
            int i = 0;
            do
            {
                if (this.grades[i] < 0)
                {
                    statisticks.Max = Math.Max(statisticks.Max, this.grades[i]);
                    statisticks.Min = Math.Min(statisticks.Min, this.grades[i]);
                    statisticks.Average += this.grades[i];
                }
                Console.WriteLine($"Grade with DoWhile: {this.grades[i]}");
                i++;

            } while (i < this.grades.Count);
            statisticks.Average /= this.grades.Count;
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
                if (this.grades[i] < 0)
                {
                    statisticks.Max = Math.Max(statisticks.Max, this.grades[i]);
                    statisticks.Min = Math.Min(statisticks.Min, this.grades[i]);
                    statisticks.Average += this.grades[i];
                }
                Console.WriteLine($"Grade with while: {this.grades[i]}");
                i++;
            }
            statisticks.Average /= this.grades.Count;
            return statisticks;
        }
    }
}
    

