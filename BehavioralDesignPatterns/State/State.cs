using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralDesignPatterns.State
{
    public abstract class State
    {
        protected CoffeeMachine CoffeeMachine { get; set; }

        public void SetContext(CoffeeMachine coffeeMachine)
        {
            CoffeeMachine = coffeeMachine;
        }

        public abstract void SmallCoffee();
        public abstract void LargeCoffee();


    }
}
