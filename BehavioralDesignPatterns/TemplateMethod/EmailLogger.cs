using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralDesignPatterns.TemplateMethod
{
    public class EmailLogger : Logger
    {
        protected override void OnCloseOutput()
        {
            Console.WriteLine("Dispose Connection");
        }

        protected override void Handle(string messageToLog)
        {
            Console.WriteLine("Sending Email with Log Message : " + messageToLog);
        }

        protected override IDisposable OnOpenOutput()
        {
            Console.WriteLine("Connecting to mail server and logging in");
            return new Service();
        }

        protected override string SerializeMessage(string message)
        {
            Console.WriteLine("Serializing message");
            return message.ToString();
        }
    }
}
