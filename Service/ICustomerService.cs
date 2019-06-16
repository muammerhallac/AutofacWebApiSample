using Core.Domain;
using System.Collections.Generic;

namespace Service
{
    public interface ICustomerService
    {
        IList<Customer> GetAll();
        void Add(Customer customer);
        void Delete(Customer customer);
        Customer GetCustomerById(int id);
    }
}
