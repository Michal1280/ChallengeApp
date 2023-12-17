using NuGet.Frameworks;

namespace ChallengeApp.tests
{
    public class Tests
    {

        [Test]
        public void WhenEmployeeCollectTwoScores_ShouldCorrectReultFromSum()
        {
            //arrange
            var user5 = new Employee("Wojtek", "Zebrowski", 15);
            user5.AddScore(5);
            user5.AddScore(7);
            user5.AddScore(8);
            user5.AddScore(-2);
            user5.AddScore(-18);
            //act
            var result = user5.Result;
            //assert
            Assert.AreEqual(0, result);
        }

    }
}