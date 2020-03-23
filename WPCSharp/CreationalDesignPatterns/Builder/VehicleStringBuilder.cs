using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPatterns.Builder
{
    public class VehicleStringBuilder : ABuilder
    {
        private Dictionary<string, string> _dictionary;

        public VehicleStringBuilder()
        {
            _dictionary = new Dictionary<string, string>();
        }

        public override ABuilder SetDoors(int doors)
        {
            _dictionary[nameof(SetDoors)] = $"{doors} doors";
            return this;
        }

        public override ABuilder SetSeets(int seats)
        {
            _dictionary[nameof(SetSeets)] = $"{seats} seats";
            return this;
        }

        public override ABuilder SetEngine(int power)
        {
            _dictionary[nameof(SetEngine)] = $"engine with {power}HP";
            return this;
        }

        public override ABuilder SetTrunk(int capacity)
        {
            _dictionary[nameof(SetTrunk)] = $"trunk capacity {capacity}";
            return this;
        }

        public override ABuilder SetWheels(int wheels)
        {
            _dictionary[nameof(SetWheels)] = $"{wheels} wheels";
            return this;
        }

        public override object Build()
        {
            return "Vehicle has: " + string.Join(", ", _dictionary.Values);
        }
    }
}
