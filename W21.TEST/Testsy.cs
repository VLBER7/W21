using Wyzwanie21;

namespace W21.TEST;

public class Testsy
{
    [Test]
    public void AverageCharCheck()
    {
        var employee = new Employee ("Jan", "Kowalski");

        employee.AddGrade('A');
        employee.AddGrade('a');
        employee.AddGrade('a');
        employee.AddGrade('a');
        var stats = employee.GetStatistics();

        Assert.AreEqual(100, stats.Average);
    }

    [Test]
    public void CharFromAtoE()
    {
        var employee = new Employee("Jan", "Kowalski");

        employee.AddGrade('X');
        employee.AddGrade('C');
        var stats = employee.GetStatistics();

        Assert.AreEqual(60, stats.Average);
    }
    [Test]
    public void CharPlusNumber()
    {
        var employee = new Employee("Jan", "Kowalski");

        employee.AddGrade('B');
        employee.AddGrade(80);
        var stats = employee.GetStatistics();

        Assert.AreEqual(80, stats.Average);
    }
}
