using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralDesignPatterns.ChainOfResponsibility
{
    public class Client
    {
        public static void Execute()
        {
            var textBox = new TextBox();
            var button = new Button();
            button.Action = () =>
            {
                if(string.IsNullOrEmpty(textBox.InputText))
                {
                    return false;
                }

                textBox.InputText = null;
                Console.WriteLine("Clear");
                return true;
            };

            textBox.Add(button);

            button.Click();
            textBox.InputText = "Test";
            button.Click();
            button.Click();
            button.Click();

            textBox.Click();
            textBox.Click();

            Console.WriteLine(button.ClickEventCounter);
            Console.WriteLine(textBox.ClickEventCounter);
        }
    }
}
