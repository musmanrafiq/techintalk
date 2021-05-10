using System;
using System.Diagnostics;
using System.ServiceProcess;

namespace WindowsService
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }

        internal void TestStartupAndStop(string[] args)
        {
            this.OnStart(args);
            Console.ReadLine();
            this.OnStop();
        }

        protected override void OnStart(string[] args)
        {
            EventLog eventLog = new EventLog();
            eventLog.Source = "Service1";
            eventLog.WriteEntry("Service1 started.", EventLogEntryType.Information);
        }

        protected override void OnStop()
        {
            EventLog eventLog = new EventLog();
            eventLog.Source = "Service1";
            eventLog.WriteEntry("Service1 stopped.", EventLogEntryType.Information);
        }
    }
}
