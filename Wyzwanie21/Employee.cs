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
            {
                statisticks.Max = Math.Max(statisticks.Max, grade);
                statisticks.Min = Math.Min(statisticks.Min, grade);
                statisticks.Average += grade;

            }

            statisticks.Average = statisticks.Average /= this.grades.Count;

            //
            return statisticks;
        }
    }
}
    

