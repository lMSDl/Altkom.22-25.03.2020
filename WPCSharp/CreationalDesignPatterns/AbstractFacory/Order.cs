using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPatterns.AbstractFacory
{
    public class Order
    {
        public ICar Car { get; }

        public Order(ICarFactory factory, Segments segment, string type)
        {
            switch(type)
            {
                case "sedan":
                    Car = factory.CreateSedan(segment);
                    break;
                case "suv":
                    Car = factory.CreateSuv(segment);
                    break;
            }
        }


    }
}
