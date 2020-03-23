using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPatterns.Builder
{
    public class Client
    {
        public static void Execute()
        {
            var director = new Director();
            director.Builder = new VehicleBuilder();
            var vehicle = director.Make();
            Console.WriteLine(vehicle.ToString());
            director.Builder = new VehicleStringBuilder();
            var vehicleManual = director.Make();

            Console.WriteLine(vehicleManual.ToString());

        }
    }
}
