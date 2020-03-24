using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDesignPatterns.Flyweight
{
    public class CarFlyweight
    {
        public string Company { get; set; }
        public string Model { get; set; }
        public Color Color { get; set; }

        public void Operation(Car uniquestate)
        {
            Console.WriteLine(JsonConvert.SerializeObject(uniquestate));
            Console.WriteLine(JsonConvert.SerializeObject(this));
        }
    }
}
