using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPatterns.Builder
{
    public class VehicleProductBuilder : VehicleBuilder
    {
        public VehicleProductBuilder() : base(new VehicleProduct())
        {

        }

        public VehicleProductBuilder SetManufacturer(string manufacturer)
        {
            ((VehicleProduct)Vehicle).Manufacturer = manufacturer;
            return this;
        }
        public VehicleProductBuilder SetModelName(string modelName)
        {
            ((VehicleProduct)Vehicle).ModelName = modelName;
            return this;
        }
    }
}
