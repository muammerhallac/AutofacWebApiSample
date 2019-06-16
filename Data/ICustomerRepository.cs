using Core.Domain;
using System.Collections.Generic;

namespace Data
{
    public interface ICustomerRepository
    {
        IList<Customer> GetAll();
        Customer GetCustomer(int id);
        void Add(Customer customer);
    }
}
