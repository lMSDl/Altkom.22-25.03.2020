using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralDesignPatterns.State
{
    public class IdleState : State
    {
        public override void LargeCoffee()
        {
            Console.WriteLine("WorkingState: make large coffee");
            CoffeeMachine.TransistionTo(new WorkingState(10));
        }

        public override void SmallCoffee()
        {
            Console.WriteLine("WorkingState: make small coffee");
            CoffeeMachine.TransistionTo(new WorkingState(5));
        }
    }
}
