using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPatterns.Builder
{
    public class VehicleBuilderFacade : VehicleBaseBuilder
    {
        public VehicleBuilderFacade()
        {

        }

        protected VehicleBuilderFacade(VehicleProduct vehicle) : base(vehicle)
        {

        }

        public VehicleProductBuilder Product => new VehicleProductBuilder(Vehicle);
        public VehicleBuilder Data => new VehicleBuilder(Vehicle);
    }
}
