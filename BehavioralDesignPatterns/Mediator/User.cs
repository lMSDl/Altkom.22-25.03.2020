using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralDesignPatterns.Mediator
{
    public class User : ChatMember
    {
        public User(string nick) : base(nick)
        {
        }

        public override void Receive(string from, string message, bool isPrivate)
        {
            if(isPrivate)
                Console.WriteLine($"{from} to {Nick}: {message}");
            else
                Console.WriteLine($"{from}: {message}");
        }

        public override void Send(string message)
        {
            Console.WriteLine($"{Nick}: {message}");
            base.Send(message);
        }

        public override void Send(string to, string message)
        {
            Console.WriteLine($"{Nick} to {to}: {message}");
            base.Send(to, message);
        }
    }
}
