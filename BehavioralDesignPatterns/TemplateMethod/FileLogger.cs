using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralDesignPatterns.TemplateMethod
{
    public class FileLogger : Logger
    {
        protected override IDisposable OnOpenOutput()
        {
            Console.WriteLine("Opening File.");
            return new Service();
        }
        protected override void Handle(string message)
        {
            Console.WriteLine("Appending Log message to file : " + message);
        }
        protected override void OnCloseOutput()
        {
            Console.WriteLine("Close File.");
        }

        protected override string SerializeMessage(string message)
        {
            Console.WriteLine("Serializing message");
            return message.ToString();
        }
    }
}
