using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPatterns.FactoryMethod
{
    public class ActionCallHelp : IAction
    {
        public void Operate(int floor)
        {
            Console.WriteLine("Wzywam pomoc na piętro " + floor);
        }
    }
}
