using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDesignPatterns.Decorator
{
    public class EmailNotification : BaseDecorator
    {
        public EmailNotification(INotification notification) : base(notification)
        {
        }

        protected override void DecoratorSend(string message)
        {
            Console.WriteLine("Email notification: " + message);
        }
    }
}
