using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzer
{
    public class MoodAnalyserCustomException:Exception
    {
        public enum ExceptionType
        {
            NULL_MESSAGE, EMPTY_MESSAGE,
            NO_SUCH_FIELD, NO_SUCH_METHOD,
            NO_SUCH_CLASS, OBJECT_CREATION_ISSUE

        }

        private readonly ExceptionType type;

        public MoodAnalyserCustomException(ExceptionType Type, string message) : base(message)
        {
            this.type = Type;
        }

        public MoodAnalyserCustomException(string message) : base(message)
        {
        }

        public string AnalyseMood()
        {
            throw new NotImplementedException();
        }
    }
}
