using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPatterns.FactoryMethod.Logistics
{
    public abstract class Vehicle
    {
        public Vehicle(float maxLoad)
        {
            MaxLoad = maxLoad;
            AverageFuelComsumption = maxLoad / 400;
        }

        public float AverageFuelComsumption { get; }
        public float MaxLoad { get; }
    }

    public class Truck : Vehicle
    {
        public Truck(float minLoad) : base(minLoad >= 7000 ? 7000 : minLoad + 1000 - minLoad % 1000)
        {
        }
    }

    public class Ship : Vehicle
    {
        public Ship(float minLoad) : base(minLoad >= 1000000 ? 1000000 : minLoad + 100000 - minLoad % 100000)
        {
        }
    }

    public enum DeliveryType
    {
        Truck,
        Ship
    }

    public abstract class Logistics
    {

        public static Logistics CreateLogistics(DeliveryType type)
        {
            switch (type)
            {
                case DeliveryType.Truck:
                    return new TruckLogistics();
                case DeliveryType.Ship:
                    return new ShipLogistics();
            }
            return null;
        }

        public float CalculateFuelConsumption(float routeLenght, float loadWeight, Vehicle vehicle)
        {
            return (float)Math.Ceiling(loadWeight / vehicle.MaxLoad) * 2 * routeLenght;
        }
        public void Deliver(Vehicle vehicle)
        {
            Console.WriteLine($"Load in delivery by {vehicle.GetType().Name}");
        }

        public abstract float PlanRoute(Vehicle vehicle);

        public abstract Vehicle PrepareVehicle(float minLoad);
    }

    public class TruckLogistics : Logistics
    {
        public override float PlanRoute(Vehicle vehicle)
        {
            return 732.3f;
        }

        public override Vehicle PrepareVehicle(float minLoad)
        {
            return new Truck(minLoad);
        }
    }

    public class ShipLogistics : Logistics
    {
        public override float PlanRoute(Vehicle vehicle)
        {
            return 300f;
        }

        public override Vehicle PrepareVehicle(float minLoad)
        {
            return new Ship(minLoad);
        }
    }
    public class Client
    {
        public void Execute()
        {
            var logistics = Logistics.CreateLogistics(DeliveryType.Ship);
            var vehicle = logistics.PrepareVehicle(5000);

            var route = logistics.PlanRoute(vehicle);
            Console.WriteLine($"Rote length: {route}");
            var fuel = logistics.CalculateFuelConsumption(route, 300000, vehicle);
            Console.WriteLine($"Planned fuel consumption: {fuel}");
            logistics.Deliver(vehicle);
        }
    }
}
