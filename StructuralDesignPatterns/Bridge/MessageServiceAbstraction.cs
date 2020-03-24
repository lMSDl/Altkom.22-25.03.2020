using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDesignPatterns.Bridge
{
    public class MessageServiceAbstraction
    {
        public IMessageServiceImplementation Implementation { get; set; }
        public MessageServiceAbstraction(IMessageServiceImplementation implementation)
        {
            Implementation = implementation;
        }

        public virtual void Send(string message)
        {
            Implementation.SendMessage(message);
        }
    }
}
