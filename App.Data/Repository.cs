using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Text;


namespace App.Data
{
    public class Repository
    {
        private readonly PizzaStoreAppContext _db;

        public Repository(PizzaStoreAppContext db)
        {
            _db = db ?? throw new ArgumentException(nameof(db));
        }

        /* Customer
         * TODO
         * 1. Create a new customer
         * 2. Get All customer
         * 3. Get  Customer by ID
         * 4. Edit Customer by ID
         * 5. Edit Customer by ID
        */

        public void AddCustomer(string firstName, string lastname, int location)
        {
            var customer = new Customer
            {
                FirstName = firstName,
                LastName = lastname,
                LocationId = location
            };

            _db.Add(customer);
        }

        public IEnumerable<Customer> GetCustomer()
        {
            List<Customer> customers = _db.Customer.AsNoTracking().ToList();
            return customers;
        }
    }
}
