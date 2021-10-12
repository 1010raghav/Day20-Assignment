using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzer;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void givenSadMoodShouldReturnSad()
        {
            
                //Arrange
                string expected = "Happy";
                string message = "I am in Happy mood";
            UC1 mood = new UC1(message);

                //ACT
                string moods = mood.Analyzemood();

            //Assert
            Assert.AreEqual(expected, moods);

        }
    }
}
