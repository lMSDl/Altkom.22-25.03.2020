using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDesignPatterns.Flyweight
{
    public class Client
    {
        public static void Execute()
        {
            var factory = new FlyweightFactory();
            var cars = new List<Car>();

            for(int i = 0; i < 500000; i++)
            {
                cars.Add(Add(factory, new Car()
                {
                    Owner = new Random(1).Next(1000, 100000).ToString(),
                    Number = new Random(1).Next(100, 1000).ToString(),
                    Company = "BMW",
                    Model = "M5",
                    Color = Color.Red
                }));

                cars.Add(Add(factory, new Car()
                {
                    Owner = new Random(1).Next(1000, 100000).ToString(),
                    Number = new Random(1).Next(100, 1000).ToString(),
                    Company = "BMW",
                    Model = "X1",
                    Color = Color.White
                }));

                cars.Add(Add(factory, new Car()
                {
                    Owner = new Random(1).Next(1000, 100000).ToString(),
                    Number = new Random(1).Next(100, 1000).ToString(),
                    Company = "Mercedes",
                    Model = "C500",
                    Color = Color.Red
                }));

                cars.Add(Add(factory, new Car()
                {
                    Owner = new Random(1).Next(1000, 100000).ToString(),
                    Number = new Random(1).Next(100, 1000).ToString(),
                    Company = "Mercedes",
                    Model = "C300",
                    Color = Color.Brown
                }));
            }

            cars.First().CarFlyweight.Operation(cars.First());

        }

        public static Car Add(FlyweightFactory factory, Car car)
        {
            var fly = factory.GetFlyweight(car.CarFlyweight);
            car.CarFlyweight = fly;
            return car;
        }
    }
}
