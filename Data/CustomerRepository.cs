using Core.Domain;
using System.Collections.Generic;
using System.Linq;

namespace Data
{
    public class CustomerRepository : ICustomerRepository
    {
        private CustomerEntities dbContext;

        protected IDbFactory DbFactory
        {
            get;
            private set;
        }

        protected CustomerEntities DbContext
        {
            get { return dbContext ?? DbFactory.Init(); }
        }

        public CustomerRepository(IDbFactory dbFactory)
        {
            DbFactory = dbFactory;
        }

        public IList<Customer> GetAll()
        {
            return DbContext.Table;
        }

        public Customer GetCustomer(int id)
        {
            return DbContext.Table.Where(x => x.Id == id).FirstOrDefault();
        }

        public void Add(Customer customer)
        {
            DbContext.Table.Add(customer);
        }
    }
}
