using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralDesignPatterns.ChainOfResponsibility
{
    public class Button : Component
    {
        public Func<bool> Action { get; set; }

        protected override void Click(bool handled)
        {
            if (!handled && Action())
            {
                Console.WriteLine("Acction completed");
                base.Click(true);
            }
            else
                base.Click(false);
        }
    }
}
