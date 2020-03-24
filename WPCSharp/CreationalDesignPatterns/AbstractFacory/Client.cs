using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPatterns.AbstractFacory
{
    public class Client
    {
        public static void Execute()
        {
            var factory = new FactoryHonda();

            var order = new Order(factory, Segments.Compact, "suv");

            Console.WriteLine(order.Car.Name());
        }
    }
}
