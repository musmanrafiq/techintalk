using System;
using System.Net;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            AppDomain UpdatesDomain = AppDomain.CreateDomain("Handle Updates");
            Type UpdateInitiator = typeof(HandleUpdates);
            UpdatesDomain.CreateInstanceAndUnwrap(UpdateInitiator.Assembly.FullName, UpdateInitiator.FullName);
            AppDomain.Unload(UpdatesDomain);

            Console.WriteLine("Our Default Domain");
            // stop the app from closing
            Console.ReadKey();
        }

       
        #region Global settings

        private static void GlobalExceptionHandler(object sender, UnhandledExceptionEventArgs e)
        {
            // log our exceptions here
            Console.WriteLine($"An Exception has reaised {e.ExceptionObject.ToString()}");
            Environment.Exit(1);
        }

        #endregion
    }
}

[Serializable]
class HandleUpdates
{
    public HandleUpdates()
    {
        Console.WriteLine("Handling updates");
    }

    ~HandleUpdates()
    {
        Console.WriteLine("Stoped handling updates");
    }
}
