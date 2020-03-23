using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.L
{
    public abstract class Vehicle
    {
        public string Name { get; set; }
        public abstract void Move();
    }

    public class Airplane : Vehicle
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying!");
        }

        public override void Move()
        {
            Fly();
        }
    }

    public class Car : Vehicle
    {
        public void Drive()
        {
            Console.WriteLine("I'm driving!");
        }

        public override void Move()
        {
            Drive();
        }
    }


}
