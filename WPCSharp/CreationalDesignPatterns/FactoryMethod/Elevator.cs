using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPatterns.FactoryMethod
{
    public class Elevator
    {
        private Dictionary<string, IAction> Actions { get; }

        public Elevator()
        {
            var type = typeof(IAction);
            Actions = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(x => x.GetTypes())
                .Where(x => !x.IsInterface)
                .Where(x => type.IsAssignableFrom(x))
                .Select(x => (IAction)Activator.CreateInstance(x))
                .ToDictionary(x => x.GetType().Name);

            //Actions = new Dictionary<string, IAction>()
            //{
            //    { nameof(ActionGoTo), new ActionGoTo() },
            //    { nameof(ActionStop), new ActionStop() },
            //    { nameof(ActionStopWhenGoingUp), new ActionStopWhenGoingUp() },
            //    { nameof(ActionStopWhenGoingDown), new ActionStopWhenGoingDown() }
            //};
        }

        public void Operate(IAction action, int floor)
        {
            action.Operate(floor);
        }


        public IAction GetAction(int action)
        {
            return Actions["Action" +  ((ElevatorActions)action).ToString()];
        }
}
}
