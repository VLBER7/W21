namespace Wyzwanie21
{
    public interface iEmployee
    {
        string Name { get; }
        string Surname { get; }
        string Sex { get; }
        Statistics GetStatistics();

    }
}
