using System;

namespace ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            // multiple value return example
            UtilizeMultiValueReturnExample();

            // to stop program from exit
            Console.ReadKey();
        }       
        
        public static void UtilizeMultiValueReturnExample()
        {
            // first way of utilizing mutiple returns from a method
            var positionResponse = MultipleValueReturnFromMethods.GetPosition();
            Console.WriteLine($"The position is {positionResponse.Item1} {positionResponse.Item2}");

            // second way of utilizing mutiple returns from a method 
            var (postion, name) = MultipleValueReturnFromMethods.GetPosition();
            Console.WriteLine($"The position is {postion} {name}");

            // third way of utilizing mutiple returns from a method
            var response = MultipleValueReturnFromMethods.GetOtherPosition();
            Console.WriteLine($"The position is {response.postion} {response.name}");            
        }
    }
}
