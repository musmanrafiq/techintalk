using Concepts.WhenKeyword;
using System;

namespace Concepts
{
    class Program
    {
        static void Main()
        {
            var example1 = new WhenExample1();
            var reslt = example1.GetStringLength(1);
            Console.WriteLine(reslt);
            Console.ReadKey();
        }
    }
}
