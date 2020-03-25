using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralDesignPatterns.Visitor
{
    public class Cart : Basket
    {
        public override void Add(Product product)
        {
            Console.WriteLine("Product in cart");
        }

        public override void Add(BoxedProduct product)
        {
            Console.WriteLine("BoxedProduct in cart");
        }
    }
}
