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
            
        }

        private static DesignPrinciples()
        {
            var customerService = new CustomerService();
            var customer = customerService.FindCustomerById(1);

            var paymentService = new PaymentService();

            paymentService.Fund(customer.PaymentAccount, 500);

            var result = paymentService.Change(customer.PaymentAccount, 100);
            if (result)
                Console.WriteLine($"Customer {customer.Id} charged. Actual balance: {customer.PaymentAccount.Balance}");
            else
                Console.WriteLine($"Not enought founds on customer {customer.Id} acconut! Actual balance: {customer.PaymentAccount.Balance}");

            Console.ReadKey();
        }
    }
}
