using Concepts.WhenKeyword;
using System;

namespace Concepts
{
    class Program
    {
        static void Main()
        {
            // in catch block
            // in swith statements
            // swith expression
            var example1 = new WhenExample1();
            var returnValue = example1.ProcessInput(9);
            Console.WriteLine(returnValue);
            Console.ReadKey();
        }
    }
}
