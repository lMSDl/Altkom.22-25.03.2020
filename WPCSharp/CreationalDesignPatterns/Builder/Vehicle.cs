using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPatterns.Builder
{
    public class Vehicle
    {
        public int Wheels { get; set; }
        public int Seats { get; set; }
        public int Doors { get; set; }
        public int? TrunckCapacity { get; set; }
        public int? EnginePower { get; set; }

        //public Vehicle(int wheels, int seats, int doors, int? trunckCapacity, int? enginePower)
        //{
        //    Wheels = wheels;
        //    Seats = seats;
        //    Doors = doors;
        //    TrunckCapacity = trunckCapacity;
        //    EnginePower = enginePower;
        //}
        //public Vehicle(int wheels, int seats, int doors, int? enginePower) : this(wheels, seats, doors, null, enginePower)
        //{
        //}

        //public Vehicle(int wheels, int seats, int? trunk, int doors) : this(wheels, seats, doors, trunk, null)
        //{
        //}
        //public Vehicle(int wheels, int seats) : this(wheels, seats, 0, null, null)
        //{
        //}


        //public override string ToString()
        //{
        //    return $"Vehicle has {Wheels} wheels, {Seats} seats, {Doors} doors" + (TrunckCapacity.HasValue ? $", trunk capacity {TrunckCapacity}l" : "") + " and " + (EnginePower.HasValue ? $"engine with {EnginePower}HP" : "no engine");
        //}
    }
}
