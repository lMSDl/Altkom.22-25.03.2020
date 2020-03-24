using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDesignPatterns.Composition
{
    public class BaseProduct : IPriceCalculator
    {
        public int Price { get; set; }

        public virtual float CalculatePrice()
        {
            return Price;
        }
    }
}
