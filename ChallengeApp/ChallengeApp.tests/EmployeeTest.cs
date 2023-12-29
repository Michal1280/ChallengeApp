using NuGet.Frameworks;

namespace ChallengeApp.tests
{
    public class EmployeeTests
    {

        [Test]
        public void WhenEmployeeCollectAllPoints_ShouldReturnMaxValue ()
        {
            //arrange
            var employee1 = new Employee("Wojtek", "Zebrowski");
            employee1.AddGrade(5);
            employee1.AddGrade(10);
            employee1.AddGrade(-10);
            employee1.AddGrade(20);
            employee1.AddGrade(15);
            //act
            var statistics = employee1.GetStatistics();
            //assert
            Assert.AreEqual(20, statistics.Max);
        }

        [Test]
        public void WhenEmployeeCollectAllPoints_ShouldReturnMinValue()
        {
            //arrange
            var employee1 = new Employee("Tomek", "Zebrowski");
            employee1.AddGrade(0);
            employee1.AddGrade(0);
            employee1.AddGrade(0);
            employee1.AddGrade(0);
            employee1.AddGrade(5);
            //act
            var statistics = employee1.GetStatistics();
            //assert
            Assert.AreEqual(0, statistics.Min);
        }

        [Test]
        public void WhenEmployeeCollectAllPoints_ShouldReturnAverageValue()
        {
            //arrange
            var employee1 = new Employee("Tomek", "Zebrowski");
            employee1.AddGrade(2);
            employee1.AddGrade(1);
            employee1.AddGrade(1);
            //act
            var statistics = employee1.GetStatistics();
            //assert
            Assert.AreEqual(1.33, Math.Round(statistics.Average,2));
        }

        [Test]
        public void WhenEmployeeCollectAllPoints_ShouldReturnAverageValueInLetter()
        {
            //arrange
            var employee1 = new Employee("Tomek", "Zebrowski");
            employee1.AddGrade(98);
            employee1.AddGrade(99);
            employee1.AddGrade(100);
            //act
            var statistics = employee1.GetStatistics();
            //assert
            Assert.AreEqual('A', statistics.AverageLetter);
        }
    }
}