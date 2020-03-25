using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralDesignPatterns.Visitor
{
    public class Basket : IVisitor
    {
        public virtual void Add(Product product)
        {
            Console.WriteLine("Product in basket");
        }

        public virtual void Add(BoxedProduct product)
        {
            Console.WriteLine("BoxedProduct in basket");
        }

        public void Visit(Product product)
        {
            Add(product);
        }

        public void Visit(BoxedProduct boxedProduct)
        {
            Add(boxedProduct);
        }
    }
}
