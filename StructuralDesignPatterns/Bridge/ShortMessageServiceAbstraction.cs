using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDesignPatterns.Bridge
{
    public class ShortMessageServiceAbstraction : MessageServiceAbstraction
    {
        public ShortMessageServiceAbstraction(IMessageServiceImplementation implementation) : base(implementation)
        {
        }

        public override void Send(string message)
        {
            if(message.Length > 10)
                Console.WriteLine("Message too long.");
            else
                base.Send(message);
        }
    }
}
