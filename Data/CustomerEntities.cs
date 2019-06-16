using Core.Domain;
using System.Collections.Generic;

namespace Data
{
    public class CustomerEntities
    {
        static IList<Customer> Customers;
        public IList<Customer> Table { get { return Customers; } set { Customers = value; } }
        public void Add(Customer customer)
        {
            Customers.Add(customer);
        }
        public void Delete(Customer customer)
        {
            Customers.Remove(customer);
        }
    }
}
