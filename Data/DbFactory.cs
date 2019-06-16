using Core.Domain;
using System.Collections.Generic;

namespace Data
{
    public class DbFactory : IDbFactory
    {
        public CustomerEntities Init()
        {
            var entities = new CustomerEntities();
            var customers = new List<Customer> {
                new Customer{ Id=1, Username = "username1", Email = "user1@email.com"},
                new Customer{ Id=2, Username = "username2", Email = "user2@email.com"},
                new Customer{ Id=3, Username = "username3", Email = "user3@email.com"},
                new Customer{ Id=4, Username = "username4", Email = "user4@email.com"}
            };

            entities.Table = customers;

            return entities;
        }
    }
}