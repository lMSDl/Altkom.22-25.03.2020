using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDesignPatterns.Composition
{
    public class Client
    {
        public static void Execute()
        {
            var box = new Box() { Price = new Random().Next(1, 10) };
            box.Products.Add(new Product() { Name = "p1", Price = new Random().Next(1, 100) });
            box.Products.Add(new Product() { Name = "p2", Price = new Random().Next(1, 100) });
            box.Products.Add(new Product() { Name = "p3", Price = new Random().Next(1, 100) });
            box.Products.Add(new Product() { Name = "p4", Price = new Random().Next(1, 100) });
            box.Products.Add(new Product() { Name = "p5", Price = new Random().Next(1, 100) });


            var box2 = new Box() { Price = new Random().Next(1, 10) };
            box2.Products.Add(new Product() { Name = "p1", Price = new Random().Next(1, 100) });
            box2.Products.Add(new Product() { Name = "p2", Price = new Random().Next(1, 100) });
            box2.Products.Add(new Product() { Name = "p3", Price = new Random().Next(1, 100) });
            box2.Products.Add(new Product() { Name = "p4", Price = new Random().Next(1, 100) });
            box2.Products.Add(new Product() { Name = "p5", Price = new Random().Next(1, 100) });

            var box3 = new Box() { Price = new Random().Next(1, 10) };
            box3.Products.Add(box);
            box3.Products.Add(box2);
            box3.Products.Add(new Product() { Name = "p1", Price = new Random().Next(1, 100) });
            box3.Products.Add(new Product() { Name = "p2", Price = new Random().Next(1, 100) });

            Console.WriteLine(box3.CalculatePrice() + " zł");

        }
        
    }
}
