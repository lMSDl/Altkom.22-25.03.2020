using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDesignPatterns.Composition
{
    public class Box : BaseProduct
    {
        public ICollection<BaseProduct> Products { get; } = new List<BaseProduct>();

        public override float CalculatePrice()
        {
            return Products.Sum(x => x.CalculatePrice()) + base.CalculatePrice();
        }
    }
}
