
using System.Reflection.Metadata;

namespace ChallengeApp.tests
{
    public class TypeTest
    {
        [Test]
        public void CheckTypeForStringVariable()
        {
            //arrange
            string number1 = "1";
            string number2 = "1";
            //act

            //assert
            Assert.AreEqual(number1, number2);
        }

        [Test]
        public void CheckTypeForDoubleVariable()
        {
            //arrange
            double number1 = (1.2);
            double number2 = (1.3);
            //act

            //assert
            Assert.AreNotEqual(number1, number2);
        }

        [Test]
        public void CheckTypeForIntVariable()
        {
            //arrange
            int number1 = 1;
            int number2 = 10;
            //act

            //assert
            Assert.AreNotEqual(number1, number2);
        }
        [Test]
        public void GetEmployeeShouldResturnDifferenceCheckRefernceType()
        {
            //arrange
            var user1 = GetEmployee("Adam", "Tomczak", 25);
            var user2 = GetEmployee("Adam", "Tomczak", 25);
            //act

            //assert
            Assert.AreNotEqual(user1, user2);
        }

        public void GetEmployee_ShouldRestureAgeComparison()
        {
            //arrange
            var user1 = GetEmployee("Adam", "Tomczak", 25);
            var user2 = GetEmployee("Adam", "Tomczak", 25);
            //act

            //assert
            Assert.AreEqual(user1.Age, user2.Age);
        }
        private Employee GetEmployee(string name, string surname, int age)
        {
            return new Employee(name, surname, age);
        }
    }
}
