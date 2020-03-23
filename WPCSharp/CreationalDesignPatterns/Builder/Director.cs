using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPatterns.Builder
{
    public class Director
    {
        public ABuilder Builder { get; set; }

        public object Make()
        {
            return
                Builder.SetDoors(4)
            .SetTrunk(500)
            .SetEngine(50)
            .SetWheels(4)
            .SetSeets(2)
            .Build();
        }
    }
}
