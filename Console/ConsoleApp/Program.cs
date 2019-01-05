using System;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {

        static void Main(string[] args)
        {
            //FirstWay();
            //SecondWay();
            //ThirdWay();
            //FourthWay();
            FifthWay();
            Console.ReadKey();
        }


        private static void FirstWay()
        {
            var cancellationTokenSource = new CancellationTokenSource();
            var token = cancellationTokenSource.Token;

            Task.Run(() => {
                while (!cancellationTokenSource.IsCancellationRequested)
                {
                    Console.WriteLine("Hello World!");
                    Thread.Sleep(200);
                }
            }, token);

            cancellationTokenSource.CancelAfter(2000);
        }

        private static void SecondWay()
        {
            var cancellationTokenSource = new CancellationTokenSource(2000);
            var token = cancellationTokenSource.Token;

            Task.Run(() => {
                while (!cancellationTokenSource.IsCancellationRequested)
                {
                    Console.WriteLine("Hello World!");
                    Thread.Sleep(200);
                }
            }, token);
       }

        private static void ThirdWay()
        {
            var cancellationTokenSource = new CancellationTokenSource();
            var token = cancellationTokenSource.Token;

            Task.Run(() => {
                while (true)
                {
                    token.ThrowIfCancellationRequested();
                    Console.WriteLine("Hello World!");
                    Thread.Sleep(200);

                }
            }, token);

            cancellationTokenSource.CancelAfter(2000);
        }

        private static void FourthWay()
        {
            var cancellationTokenSource = new CancellationTokenSource();
            var token = cancellationTokenSource.Token;

            Task.Run(() => {
                try
                {
                    while (true)
                    {
                        token.ThrowIfCancellationRequested();
                        Console.WriteLine("Hello World!");
                        Thread.Sleep(200);
                    }
                }
                catch (Exception exp)
                {

                }
                finally
                {
                    Console.WriteLine("Let's close this up guys!");
                }
            }, token);

            cancellationTokenSource.CancelAfter(2000);
        }

        private static void FifthWay()
        {
            var cancellationTokenSource = new CancellationTokenSource();
            var token = cancellationTokenSource.Token;

            Task.Run(() => {
                while (!cancellationTokenSource.IsCancellationRequested)
                {
                    Console.WriteLine("Hello World!");
                    Thread.Sleep(200);
                }
            }, token);

            cancellationTokenSource.CancelAfter(2000);
            token.Register(() => {
                Console.WriteLine("Register is get called!");
            });
        }
    }
}
