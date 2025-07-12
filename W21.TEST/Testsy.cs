using Wyzwanie21;

namespace W21.TEST;

public class Testsy
{
    [Test]
    public void TestAverageValueCheck()
    {
        var employee = new Employee("Roman", "Romanski");

        employee.AddGrade(4);
        employee.AddGrade(7);
        employee.AddGrade(5);

        var statisticks = employee.GetStatisticks();

        Assert.That(statisticks.Average, Is.EqualTo(5.33f).Within(0.01f));
    }
    [Test]
    public void TestMinValueCheck()
    {
        var employee = new Employee("Roman", "Romanski");

        employee.AddGrade(4.1f);
        employee.AddGrade(7);
        employee.AddGrade(5);

        var statisticks = employee.GetStatisticks();

        Assert.That(statisticks.Min, Is.EqualTo(4).Within(0.1f));
    }
    [Test]
    public void TestMaxValueCheck()
    {
        var employee = new Employee("Roman", "Romanski");

        employee.AddGrade(4);
        employee.AddGrade(6.99f);
        employee.AddGrade(5);

        var statisticks = employee.GetStatisticks();

        Assert.That(statisticks.Max, Is.EqualTo(7).Within(0.1f));
    }
}

