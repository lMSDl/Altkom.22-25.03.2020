using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralDesignPatterns.Visitor
{
    public class Client
    {
        public static void Execute()
        {
            var products = new List<Product> { new Product(), new BoxedProduct() };

            foreach (var item in products)
            {
                item.PrintType();
            }

            var baskets = new List<Basket> { new Basket(), new Cart() };

            foreach (var product in products)
            {
                foreach (var basket in baskets)
                {
                    product.Accept(basket);
                }
            }

        }
    }
}
