using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralDesignPatterns.State
{
    public class HeatingUpState : State
    {
        public HeatingUpState()
        {
            var task = Task.Delay(TimeSpan.FromSeconds(5));
            task.ContinueWith(x => CoffeeMachine.TransistionTo(new IdleState()));
        }

        public override void LargeCoffee()
        {
            Console.WriteLine("HeatingUpState: I'm not ready");
        }

        public override void SmallCoffee()
        {
            Console.WriteLine("HeatingUpState: I'm not ready");
        }
    }
}
