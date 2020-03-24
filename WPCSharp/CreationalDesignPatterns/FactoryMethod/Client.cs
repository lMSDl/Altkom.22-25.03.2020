using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPatterns.FactoryMethod
{
    public class Client
    {
        public static void Execute()
        {
            var elevator = new Elevator();

            var enumAction = GetAction();
            var floor = GetFloor();
            IAction action = elevator.GetAction(enumAction);

            elevator.Operate(action, 7);

        }

        public static int GetAction()
        {
            return (int)ElevatorActions.CallHelp;
        }

        public static int GetFloor()
        {
            return 7;
        }

    }
}
