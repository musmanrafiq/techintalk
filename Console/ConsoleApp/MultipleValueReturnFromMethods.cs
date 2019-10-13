using System;

namespace ConsoleApp
{
    public class MultipleValueReturnFromMethods
    {
        public static (int, string) GetPosition()
        {
            return (1, "Usman");
        }
        public static (int postion, string name) GetOtherPosition()
        {
            return (1, "Usman");
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

            throw new Exception();
        }
    }
}
