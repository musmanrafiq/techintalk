using FeaturesExplore.InitOnly;
using System;

namespace FeaturesExplore
{
    class Program
    {
        static void Main(string[] args)
        {

            var student = new Student { Fee = 10 };
            student.Fee = 50;

            Console.WriteLine(student.Fee);
        }
    }
}
