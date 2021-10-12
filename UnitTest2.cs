using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzer;

namespace TestProject2
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void givenSadMoodShouldReturnSad()
        {
            
                //Arrange
                string expected = "Happy";
                string message = "I am in Happy mood";
            UC2 mood = new UC2(message);

                //ACT
                string moods = mood.Analyzemood();

            //Assert
            Assert.AreEqual(expected, moods);
        }
        [TestMethod]
      // [DataRow("I am in HAPPY Mood")]
        [DataRow(null)]
        public void GivenHAPPYMoodShouldReturnHappy(string message)
        {
            //Arrange
            string expected = "HAPPY";
            UC2 moodAnalyse = new UC2(message);

            //Act
            string moood = moodAnalyse.Analyzemood();

            // ASSERT
            Assert.AreEqual(expected, moood);



        }
    }
}
