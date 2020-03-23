using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPatterns.Builder
{
    public abstract class ABuilder
    {
        public abstract ABuilder SetDoors(int doors);

        public abstract ABuilder SetSeets(int seats);

        public abstract ABuilder SetEngine(int power);

        public abstract ABuilder SetTrunk(int capacity);

        public abstract ABuilder SetWheels(int wheels);

        public abstract object Build();
    }
}
