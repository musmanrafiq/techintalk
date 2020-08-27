using System;
using System.Threading.Tasks;

namespace AsyncAwaitExamples
{
    class Program
    {
        static async Task Main(string[] args)
        {
            int count = 0;
            Console.WriteLine("Hello World!");
            var task = DoIt1();
            Console.WriteLine("Bye world World!");
            for (int i = 0; i < 5000; i++)
            {
                count += i;
            }
            await task;
        }

        private static async Task DoIt1()
        {
            await Task.Delay(3000);
            Console.WriteLine("Do It1 done");
        }
    }
}
