using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzer
{
    public class UC2
    {
        private string message;

        public UC2(string message)
        {
            this.message = message;
        }
        public string Analyzemood()
        {
            try
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
            catch
            {
                return "HAPPY";
            }
        }
        
    }
}
