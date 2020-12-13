using FeaturesExplore.Records;
using System;

namespace FeaturesExplore
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee e = new Employee("e")
            {
                FullName = "test"
            };
            Employee ee = e with { FullName = "T" };
            Console.WriteLine(ee.FullName);
        }
    }
}
