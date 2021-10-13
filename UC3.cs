using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzer
{
    public class UC3
    {
        private string message;

        public UC3(string message)
        {
            this.message = message;
        }
        public string Analyzemood()
        {
            //try
            //{
            //    if (this.message.Contains("Sad"))
            //    {
            //        return "SAD";
            //    }
            //    else
            //    {
            //        return "Happy";
            //    }
            //}
            //catch
            //{
            //    return "HAPPY";
            //}
            try
            {
                if (this.message.Equals(string.Empty))
                {
                    throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.EMPTY_MESSAGE, "Mood should not be empty");
                }
                if(this.message.Contains("Sad"))
                {
                    return "SAD";
                }
                else
                {
                    return "HAPPy";
                }
            }
            catch(NullReferenceException)
            {
                throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.NULL_MESSAGE, "Mood should not be NULL");
            }
        }

        public static string AnalyseMood()
        {
            throw new NotImplementedException();
        }
    }
}
