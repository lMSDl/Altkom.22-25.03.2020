using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralDesignPatterns.ChainOfResponsibility
{
    public abstract class Component
    {
        public Component Parent { get; internal set; }

        public void Click()
        {
            Click(false);
        }

        public int ClickEventCounter { get; private set; }

        protected virtual void Click(bool handled)
        {
            ClickEventCounter++;
            Parent?.Click(handled);
        }
    }
}
