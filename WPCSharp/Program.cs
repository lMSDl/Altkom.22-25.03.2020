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
            var customerService = new CustomerService();
            var customer = customerService.FindCustomerById(1);

            var paymentService = new PaymentService();


            paymentService.Fund(customer, 500);
            var result = paymentService.Change(customer, 100);
            var balance = customer.PaymentAccount.Balance;
            if (result)
                Console.WriteLine($"Customer {customer.Id} charged. Actual balance: {balance}");
            else
                Console.WriteLine($"Not enought founds on customer {customer.Id} acconut! Actual balance: {balance}");

            Console.ReadKey();
        }
    }
}
