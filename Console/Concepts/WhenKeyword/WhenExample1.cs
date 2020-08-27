using System;

namespace Concepts.WhenKeyword
{
    public class WhenExample1
    {
        public string ProcessInput(object input)
        {
            try
            {
                switch (input)
                {
                    case string temVeriable when (!string.IsNullOrEmpty(temVeriable)):
                        return $"This is a string with lenght of {temVeriable.Length}";
                    case int temVeriable when (temVeriable > 0):
                        return $"This is an int and its value is {temVeriable}";
                    default:
                        return "No case matched";
                }
            }
            catch (Exception exp) when (exp.Message.Contains("abc"))
            {

            }
            catch (Exception exp)
            {

            }
            return string.Empty;
        }

    }
}
