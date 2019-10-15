using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomainExample
{
    class Program
    {
        // 1 - ISOLATION 
        // 2 - Plugins
        // 3 - Security

        static void Main(string[] args)
        {

            AppDomain notificationDomain = AppDomain.CreateDomain("Its a Notification Domain");
            Type notificationType = typeof(NotificationManager);
            notificationDomain.CreateInstanceAndUnwrap(notificationType.Assembly.FullName, notificationType.FullName);
           
            Console.WriteLine("This is default app domain");
            Console.ReadKey();
        }
    }

    [Serializable]
    class NotificationManager
    {
        public NotificationManager()
        {
            Console.WriteLine("Its notification domain starting...");
        }

        ~ NotificationManager()
        {
            Console.WriteLine("Notification domain closed ...");
        }
    }
}
