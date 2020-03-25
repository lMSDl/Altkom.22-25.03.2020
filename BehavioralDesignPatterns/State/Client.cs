using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralDesignPatterns.State
{
    public class Client
    {
        public static void Execute()
        {

            var machine = new CoffeeMachine();

            machine.LargeCoffee();

            Task.Delay(TimeSpan.FromSeconds(7)).ContinueWith(x => machine.SmallCoffee());

            Task.Delay(TimeSpan.FromSeconds(15)).ContinueWith(x => machine.LargeCoffee());

            Task.Delay(TimeSpan.FromSeconds(20)).ContinueWith(x => machine.LargeCoffee());

        }
    }
}
