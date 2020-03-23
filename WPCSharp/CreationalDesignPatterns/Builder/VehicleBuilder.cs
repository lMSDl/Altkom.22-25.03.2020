using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPatterns.Builder
{
    public class VehicleBuilder : ABuilder
    {
        protected Vehicle Vehicle { get; }

        public VehicleBuilder()
        {
            Vehicle = new Vehicle();
        }

        protected VehicleBuilder(Vehicle vehicle)
        {
            Vehicle = vehicle;
        }

        public override ABuilder SetDoors(int doors)
        {
            Vehicle.Doors = doors;
            return this;
        }

        public override ABuilder SetSeets(int seats)
        {
            Vehicle.Seats = seats;
            return this;
        }

        public override ABuilder SetEngine(int power)
        {
            Vehicle.EnginePower = power;
            return this;
        }

        public override ABuilder SetTrunk(int capacity)
        {
            Vehicle.TrunckCapacity = capacity;
            return this;
        }

        public override ABuilder SetWheels(int wheels)
        {
            Vehicle.Wheels = wheels;
            return this;
        }

        public override object Build()
        {
            return Vehicle;
        }
    }
}
