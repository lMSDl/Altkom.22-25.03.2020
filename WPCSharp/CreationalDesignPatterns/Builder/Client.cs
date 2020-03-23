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
            var builder = new VehicleBuilderFacade();
            var vehicle = builder
                .Data
                    .SetDoors(4)
                    .SetTrunk(200)
                    .SetWheels(4)
                .Product
                    .SetManufacturer("Altkom")
                    .SetModelName("AbC")
                .Build();

            Console.WriteLine(vehicle.ToString());

        }
    }
}
