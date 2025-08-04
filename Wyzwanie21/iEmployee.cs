namespace Wyzwanie21
{
    public interface iEmployee
    {
        string Name { get; }
        string Surname { get; }
        string Sex { get; }
        void AddGrade(string grade);
        Statistics GetStatistics();

    }
} 
