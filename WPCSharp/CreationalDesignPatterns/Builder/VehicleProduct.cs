using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPatterns.Builder
{
    public class VehicleProduct : Vehicle
    {
        public string Manufacturer { get; set; }
        public string ModelName { get; set; }
    }
}
