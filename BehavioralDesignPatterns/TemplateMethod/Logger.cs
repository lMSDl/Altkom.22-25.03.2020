using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralDesignPatterns.TemplateMethod
{
    public abstract class Logger
    {
        public void Log(string message)
        {
            string messageToLog = SerializeMessage(message);
            var diposable = OpenOutput();
            Handle(messageToLog);
            CloseOutput(diposable);
        }

        protected void CloseOutput(IDisposable disposable)
        {
            OnCloseOutput();
            disposable.Dispose();
        }
        protected abstract void Handle(string messageToLog);
        protected IDisposable OpenOutput()
        {
            Console.WriteLine("Opening output...");
            return OnOpenOutput();
        }

        protected abstract IDisposable OnOpenOutput();
        protected virtual void OnCloseOutput() { }
        protected abstract string SerializeMessage(string message);
    }
}
