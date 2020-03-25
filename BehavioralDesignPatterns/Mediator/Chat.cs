using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralDesignPatterns.Mediator
{
    public class Chat : IChatMediator
    {
        private ICollection<ChatMember> _chatMembers = new List<ChatMember>();

        public void Join(ChatMember member)
        {
            if (!_chatMembers.Contains(member))
                _chatMembers.Add(member);
        }

        public void Quit(ChatMember member)
        {
            _chatMembers.Remove(member);
        }

        public void Send(string from, string to, string message)
        {
            if(to == null)
            {
                _chatMembers.Where(x => x.Nick != from).ToList().ForEach(x => x.Receive(from, message, false));
            }
            else
            {
                _chatMembers.SingleOrDefault(x => x.Nick == to)?.Receive(from, message, true);
            }

        }
    }
}
