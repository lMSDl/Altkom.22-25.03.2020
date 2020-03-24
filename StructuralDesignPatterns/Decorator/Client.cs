using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDesignPatterns.Decorator
{
    public class Client
    {
        public static void Execute()
        {
            var text = Console.ReadLine();
            
            INotification notification = new Notification();
            if (text.Length < 10)
                notification = new SmsNotification(notification);

            notification = new EmailNotification(notification);
            notification.Send(text);


        }
    }
}
