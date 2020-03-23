using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPatterns.Builder
{
    public abstract class VehicleBaseBuilder
    {
        protected VehicleProduct Vehicle { get; }

        public VehicleBaseBuilder()
        {
            Vehicle = new VehicleProduct();
        }
        protected VehicleBaseBuilder(VehicleProduct vehicle)
        {
            Vehicle = vehicle;
        }

        public Vehicle Build()
        {
            return Vehicle;
        }
    }
}
