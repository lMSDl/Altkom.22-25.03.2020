using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPatterns.Builder
{
    public class VehicleBuilder : VehicleBuilderFacade
    {
        public VehicleBuilder(VehicleProduct vehicle) : base(vehicle)
        {

        }

        public VehicleBuilder SetDoors(int doors)
        {
            Vehicle.Doors = doors;
            return this;
        }

        public VehicleBuilder SetSeets(int seats)
        {
            Vehicle.Seats = seats;
            return this;
        }

        public VehicleBuilder SetEngine(int power)
        {
            Vehicle.EnginePower = power;
            return this;
        }

        public VehicleBuilder SetTrunk(int capacity)
        {
            Vehicle.TrunckCapacity = capacity;
            return this;
        }

        public VehicleBuilder SetWheels(int wheels)
        {
            Vehicle.Wheels = wheels;
            return this;
        }
    }
}
