namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GuessHeight(10);

            Console.WriteLine("Hello, World!");
        }

        public static void GuessHeight(in int age)
        {
            // just uncomment the line no. 15 and check the megic
            //age = 10;
        }
    }


}