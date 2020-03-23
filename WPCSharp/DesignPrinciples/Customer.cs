using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrinciples
{
    public class Customer
    {
        public Customer(int id)
        {
            Id = id;
        }

        public int Id { get; }
        public float Income { get; set; }
        public float Outcome { get; set; }

        public float AllowedDebit { get; set; }
    }
}
