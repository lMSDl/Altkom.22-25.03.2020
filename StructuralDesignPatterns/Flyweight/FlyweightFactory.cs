using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDesignPatterns.Flyweight
{
    public class FlyweightFactory
    {
        private Dictionary<string, CarFlyweight> FlyWeights { get; } = new Dictionary<string, CarFlyweight>();


        public string GetKey(CarFlyweight car)
        {
            var list = new { color = car.Color.ToArgb().ToString("x"), car.Company, car.Model };
            return string.Join("_", list);
        }

        public CarFlyweight GetFlyweight(CarFlyweight car)
        {
            var key = GetKey(car);

            if(!FlyWeights.ContainsKey(key))
            {
                FlyWeights[key] = car;
            }

            return FlyWeights[key];
        }


    }
}
