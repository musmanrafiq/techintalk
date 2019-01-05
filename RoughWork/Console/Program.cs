using System;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CancellationTokenSource tokenSource = new CancellationTokenSource();
            CancellationToken token = tokenSource.Token;

            Task.Run(() =>
            {
                while (!tokenSource.IsCancellationRequested)
                {
                    token.ThrowIfCancellationRequested(); 
                    Console.WriteLine("Hello World!");
                    Thread.Sleep(200);
                }
            }, token);
            tokenSource.Cancel();

            Console.ReadKey();
        }
    }
}
