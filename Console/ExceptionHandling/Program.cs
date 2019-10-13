using System;
using System.Net;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            AppDomain.CurrentDomain.UnhandledException += GlobalExceptionHandler;

            WebClient wb = null;

            try
            {
                wb = new WebClient();
                string content = wb.DownloadString("https://www.youtu");
            }
            catch(WebException exp)
            {

            }
            finally
            {
                wb.Dispose();
            }

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
