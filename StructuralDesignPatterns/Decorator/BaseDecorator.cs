using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDesignPatterns.Decorator
{
    public abstract class BaseDecorator : INotification
    {
        private readonly INotification _notification;

        public BaseDecorator(INotification notification)
        {
            this._notification = notification;
        }

        public void Send(string message)
        {
            _notification?.Send(message);
            DecoratorSend(message);
        }

        protected abstract void DecoratorSend(string message);
    }
}
