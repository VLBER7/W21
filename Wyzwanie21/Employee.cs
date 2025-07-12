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
            this.grades.Add(grade);
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
    

