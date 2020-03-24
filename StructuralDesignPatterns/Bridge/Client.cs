using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDesignPatterns.Bridge
{
    public class Client
    {
        public static void Execute()
        {
            MessageServiceAbstraction messageService = new MessageServiceAbstraction(new SmsServiceImplementation());
            messageService.Send(Console.ReadLine());

            messageService.Implementation = new EmailServiceImplementation();
            messageService.Send(Console.ReadLine());

        }
    }
}
