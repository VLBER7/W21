
using Wyzwanie21;

namespace W21.TEST
{
    public class Tests
    {
       
        // arrange / act / assert - przygotowanie / przebieg / oczekiwianie 
        [Test]
        public void UserPointsSummaryTest()
        {
            var testEmployee = new employee("Tester", "Testowski", 45);
            testEmployee.AddScore(1);
            testEmployee.AddScore(-5);

            var result = testEmployee.Result;
            //deklaracja oczekiwanej sumy 
            Assert.AreEqual(-4, result);
        }
        [Test]
        public void UserGetMoreOrLessThanZeroPoints()
        {
            var testEmployee = new employee("Tester", "Testowski", 45);
            testEmployee.AddScore(-10);
            testEmployee.AddScore(9);

            var result = testEmployee.Result;
            //zawsze sprawdzi czy != 0
            Assert.AreNotEqual(0, result);

        }
   

        

    }
}