using System;
using System.Linq;

namespace PasswordGenerator
{
    public class Program
    {
        static void Main(string[] args)
        {

            var program = new Program();

            Console.WriteLine(program.GenerateString(12));
        }

        private string GenerateString(int length)
        {
            Random random = new Random();
            var setOfCharacters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ123456789";
            var randomString = new string(Enumerable.Repeat(setOfCharacters, length)
                .Select(str => str[random.Next(str.Length)]).ToArray()) ;
            return randomString;
        }
    }
}