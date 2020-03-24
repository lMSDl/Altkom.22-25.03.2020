using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPatterns.FactoryMethod
{
    public enum ElevatorActions
    {
        GoTo,
        Stop,
        StopWhenGoingDown,
        StopWhenGoingUp,
        CallHelp
    }
}
