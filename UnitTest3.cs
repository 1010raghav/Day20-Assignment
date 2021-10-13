using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzer;

namespace TestProject1
{
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void givenSadMoodShouldReturnSad()
        {
            
                //Arrange
                string expected = "Happy";
                string message = "I am in Happy mood";
            UC3 mood = new UC3(message);

                //ACT
                string moods = mood.Analyzemood();

            //Assert
            Assert.AreEqual(expected, moods);
        }
        [TestMethod]
        [DataRow("I am in HAPPY Mood")]
        [DataRow(null)]
        public void GivenHAPPYMoodShouldReturnHappy(string message)
        {
            //Arrange
            string expected = "HAPPY";
            UC3 moodAnalyse = new UC3(message);

            //Act
            string moood = moodAnalyse.Analyzemood();

            // ASSERT
            Assert.AreEqual(expected, moood);
        }



        //TC3.2
        //Given-When-Then
        public void Given_NULL_Mood_should_throw_moodAnalysisException()
        {
            try
            {
                string message = "";
                UC3 moodAnalyse = new UC3(message);
                string mood = UC3.AnalyseMood();
            }
            catch(MoodAnalyserCustomException e)
            {
                Assert.AreEqual("Mood should not be Empty",e.Message);
            }
        }


        //TC3.1
        [TestMethod]
        public void Given_NULL_Mood_Should_Throw_MoodAnalysisEXception()
        {
            try
            {
                string message = null;
                UC3 moodAnalysed = new UC3(message);
                string moodss = UC3.AnalyseMood();
            }
            catch (MoodAnalyserCustomException e)
            {
                Assert.AreEqual("Mood should not be Null",e.Message);
            }
        }
    }
}
