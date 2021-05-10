using System;
using System.Diagnostics;
using System.ServiceProcess;
using System.Threading;
using System.Timers;

namespace WindowsService
{
    public partial class Service1 : ServiceBase
    {
        System.Timers.Timer _timer;
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
            _timer = new System.Timers.Timer(3000);
            _timer.Elapsed += new System.Timers.ElapsedEventHandler(worker);
            _timer.Start();

            EventLog eventLog = new EventLog();
            eventLog.Source = "Service1";
            eventLog.WriteEntry("Service1 started.", EventLogEntryType.Information);
        }

        private void worker(object sender, ElapsedEventArgs e)
        {
            logEvent("Do work started");
            _timer.Stop();
            logEvent("Timer stopped");

            Thread.Sleep(3000);

            _timer.Start();
            logEvent("Timer started");

        }

        protected override void OnStop()
        {
            _timer.Stop();
            
            _timer.Dispose();
            logEvent("Service1 stopped.");
        }

        private void logEvent(string message)
        {
            EventLog eventLog = new EventLog();
            eventLog.Source = "Service1";
            eventLog.WriteEntry(message, EventLogEntryType.Warning);
        }
    }
}
