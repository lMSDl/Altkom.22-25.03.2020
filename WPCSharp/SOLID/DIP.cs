using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    public interface IMessage
    {
        void SendMessage();
    }

    class SMS : IMessage
    {
        public string Number { get; set; }
        public string COntent { get; set; }

        public void SendMessage()
        {
            SendSMS();
        }

        public void SendSMS()
        {
            Console.WriteLine("Sending SMS...");
        }
    }

    public class MMS : IMessage
    {
        public string Number { get; set; }
        public byte[] Content { get; set; }

        public void SendMessage()
        {
            SendMMS();
        }

        public void SendMMS()
        {
            Console.WriteLine("Sending MMS...");
        }
    }

    public class Mail : IMessage
    {
        public string Address { get; set; }
        public string Subject { get; set; }
        public string COntent { get; set; }

        public void SendMail()
        {
            Console.WriteLine("Sending Mail...");
        }

        public void SendMessage()
        {
            SendMail();
        }
    }

    class Messenger
    {
        public IEnumerable<IMessage> Services { get; set; }

        public void SendMessage()
        {
            if(Services != null)
                foreach (var service in Services)
                {
                    service.SendMessage();
                }
        }
    }
}
