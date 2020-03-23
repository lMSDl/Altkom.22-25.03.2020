using DesignPrinciples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new Service();

            var customerId = 1;

            service.Fund(customerId, 500);
            if (service.Change(customerId, 100))
                Console.WriteLine($"Customer {customerId} charged. Actual balance: {service.GetBalance(customerId)}");
            else
                Console.WriteLine($"Not enought founds on customer {customerId} acconut! Actual balance: {service.GetBalance(customerId)}");

            Console.ReadKey();
        }
    }
}
