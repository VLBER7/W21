using NUnit.Framework.Constraints;
using System.Reflection.Metadata;
using System.Xml.Linq;
using Wyzwanie21;

namespace W21.TEST
{
    public class TypeTests
    {
        [Test]
        public void AdditionFloatGivesTheExpectedResult()
        {
            float number1 = 1.5f;
            float number2 = 1.5f;

            Assert.That(number1 + number2, Is.EqualTo(3f));
        }
        [Test]
        public void NumberAreEqualToTheSecond()
        {
            int number1 = 11;
            int number2 = 11;

            Assert.That(number1, Is.EqualTo(number2));
        }
        [Test]
        public void StringNotEqual()
        {
            string name1 = "Roman";
            string name2 = "Romanek";

            Assert.That(name1, Is.Not.EqualTo(name2));

        }
        [Test]
        public void UserNotEqual() 
        {
            var Employee1 = GetEmployee("Roman", "Romanski", 45);
            var Employee2 = GetEmployee("Roman", "Romanski", 47);

            Assert.That(Employee1, Is.Not.EqualTo(Employee2));
        }
        private Employee GetEmployee(string name, string surname, int age)
        {
            return new Employee(name, surname, age);
        }
    }
}
