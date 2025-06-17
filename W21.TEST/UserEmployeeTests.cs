
using Wyzwanie21;

namespace W21.TEST
{
    public class Tests
    {

        // arrange / act / assert - przygotowanie / przebieg / oczekiwianie 
        [Test]
        public void UserPointsSummaryTest()
        {
            var testEmployee = new Employee("Tester", "Testowski", 45);
            testEmployee.AddScore(-1);
            testEmployee.AddScore(5);

            var result = testEmployee.Result;
            //deklaracja oczekiwanej sumy 
            Assert.That(result, Is.EqualTo(4));
        }
        [Test]
        public void UserGetMoreOrLessThanZeroPoints()
        {
            var testEmployee = new Employee("Checker", "Checkowski", 54);
            testEmployee.AddScore(-9);
            testEmployee.AddScore(7);

            var result = testEmployee.Result;
            //zawsze sprawdzi czy != 0
            Assert.That(result, Is.Not.EqualTo(0));

        }




    }
}