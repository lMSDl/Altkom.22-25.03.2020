using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralDesignPatterns.State
{
    public class CoffeeMachine
    {
        private State _state = null;

        public CoffeeMachine()
        {
            TransistionTo(new HeatingUpState());
        }

        public void TransistionTo(State state)
        {
            Console.WriteLine($"CoffeeMachine: Transition to {state.GetType().Name}");
            _state = state;
            _state.SetContext(this);
        }

        public void SmallCoffee()
        {
            _state.SmallCoffee();
        }
        public void LargeCoffee()
        {
            _state.LargeCoffee();
        }
    }
}
