using System;
using System.Collections.Generic;
using Core.Domain;
using Data;

namespace Service
{
    public class CustomerService : ICustomerService
    {
        private ICustomerRepository customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository;
        }

        public void Add(Customer customer)
        {
            customerRepository.Add(customer);
        }

        public void Delete(Customer customer)
        {
            throw new NotImplementedException();
        }

        public IList<Customer> GetAll()
        {
            return this.customerRepository.GetAll();
        }

        public Customer GetCustomerById(int id)
        {
            return this.customerRepository.GetCustomer(id);
        }
    }
}
