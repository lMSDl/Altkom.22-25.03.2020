using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralDesignPatterns.TemplateMethod
{
    public class DatabaseLogger : Logger
    {
        protected override void OnCloseOutput()
        {
            Console.WriteLine("Closing DB connection.");
        }

        protected override void Handle(string messageToLog)
        {
            Console.WriteLine("Inserting Log Message to DB table : " + messageToLog);
        }

        protected override IDisposable OnOpenOutput()
        {
            Console.WriteLine("Connecting to Database.");
            return new Service();
        }

        protected override string SerializeMessage(string message)
        {
            Console.WriteLine("Serializing message");
            return message.ToString();
        }
    }
}
