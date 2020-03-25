using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralDesignPatterns.Mediator
{
    public class Bot : ChatMember
    {
        public Bot(string nick) : base(nick)
        {
        }

        public override void Receive(string from, string message, bool isPrivate)
        {
            if (isPrivate)
                Chat.Send(Nick, from, message);
            else if(message.Contains(Nick))
                Chat.Send(Nick, null, message);
        }
    }
}
