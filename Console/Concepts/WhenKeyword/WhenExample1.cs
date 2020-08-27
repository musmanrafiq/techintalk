using System;

namespace Concepts.WhenKeyword
{
    public class WhenExample1
    {
        public string GetStringLength(object input)
        {
            try
            {
                switch (input)
                {
                    case string inputj when inputj.Length > 0:
                        return $"Its a string and its length is {inputj.Length}";

                    case int inputj when inputj > 0:
                        return $"Its an int and its value is {inputj}";

                    default:
                        return "No case matched";
                }
            }
            catch (Exception exp) when (exp.Message.Contains("reference"))
            {

            }
            return string.Empty;
        }
    }
}
