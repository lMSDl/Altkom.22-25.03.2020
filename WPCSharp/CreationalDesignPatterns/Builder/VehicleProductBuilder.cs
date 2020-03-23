using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPatterns.Builder
{
    public class VehicleProductBuilder : VehicleBuilderFacade
    {
        public VehicleProductBuilder(VehicleProduct vehicle) : base(vehicle)
        {

        }

        public VehicleProductBuilder SetManufacturer(string manufacturer)
        {
            Vehicle.Manufacturer = manufacturer;
            return this;
        }
        public VehicleProductBuilder SetModelName(string modelName)
        {
            Vehicle.ModelName = modelName;
            return this;
        }
    }
}
