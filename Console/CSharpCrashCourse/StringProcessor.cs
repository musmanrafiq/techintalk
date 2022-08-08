namespace CSharpCrashCourse
{
    public class StringProcessor
    {
        public static void ProcessInput()
        {
            while (true)
            {
                Console.WriteLine("Please enter a string or type exit to close the program!");

                string userInput = Console.ReadLine();

                if(userInput == "exit")
                {
                    break;
                }
                if(string.IsNullOrEmpty(userInput))
                {
                    Console.WriteLine("Please enter a valid string!");
                    continue;
                }
                Console.WriteLine($"String length is : {userInput.Trim().Length}");
                Console.WriteLine();

            }
        }
    }
}
