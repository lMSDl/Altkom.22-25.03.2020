using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralDesignPatterns.Visitor
{
    public interface IVisitor
    {
        void Visit(Product product);
        void Visit(BoxedProduct boxedProduct);
    }
}
