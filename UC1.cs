using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzer
{
    public class UC1
    {
        private string message;

        public UC1(string message)
        {
            this.message = message;
        }
        public string Analyzemood()
        {
            if (this.message.Contains("Sad"))
            {
                return "SAD";
            }
            else
            {
                return "Happy";
            }
        }
    }
}
