using Core.Domain;
using System.Collections.Generic;
using System.Web.Http;
using Data;
using Service;

namespace CustomerApi.Controllers
{
    public class CustomersController : ApiController
    {
        private readonly ICustomerService _customerService;

        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        public IList<Customer> GetCustomerList()
        {
            return _customerService.GetAll();
        }

        public Customer GetCustomer(int id)
        {
            return _customerService.GetCustomerById(id);
        }

        [HttpPost]
        public IHttpActionResult NewCustomer(Customer customer)
        {
            _customerService.Add(customer);
            return Ok<Customer>(customer);
        }
    }
}