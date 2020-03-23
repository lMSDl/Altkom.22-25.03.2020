using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrinciples
{
    public class Service
    {
        private ICollection<Customer> Customers { get; } = new List<Customer> { new Customer(1), new Customer(2), new Customer(3), new Customer(4), new Customer(5) };

        public bool DeleteCustomer(Customer param)
        {
            return Customers.Remove(param);
        }

        public Customer FindCustomerByAllowedDebit(float allowedDebit)
        {
            return Customers.SingleOrDefault(x => x.AllowedDebit == allowedDebit);
        }

        public Customer FindCustomerById(int customerId)
        {
           return Customers.SingleOrDefault(x => x.Id == customerId);
        }

        public bool Change(int id, float amount)
        {
            var customer = FindCustomerById(id);
            if (customer == null)
                return false;

            if (GetBalance(id) < amount)
                return false;

            customer.Outcome += amount;
            return true;
        }

        public void Fund(int customerId, float amount)
        {
            var customer = FindCustomerById(customerId);
            if (customer == null)
                return;
            customer.Income += amount;
        }

        public float? GetBalance(int customerId)
        {
            var customer = FindCustomerById(customerId);
            return customer?.Income - customer?.Outcome + customer.AllowedDebit;
        }
    }
}
