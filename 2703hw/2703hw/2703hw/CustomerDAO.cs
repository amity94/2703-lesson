using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2703hw
{
    class CustomerDAO : ICustomerDAO
    {
       
        public void AddCustomer(Customer c)
        {
            throw new NotImplementedException();
        }

        public void DeleteCustomer(int id)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAllCustomers()
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetCustomerBetweenAges(int minAge, int maxAge)
        {
            throw new NotImplementedException();
        }

        public Customer GetCustomerById(int id)
        {
            throw new NotImplementedException();
        }

        public Customer GetCustomerByPhoneNumber(string phone)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetCustomerLivingInCity(string city)
        {
            throw new NotImplementedException();
        }

        public void RemoveAllCustomers()
        {
            throw new NotImplementedException();
        }

        public void UpdateCustomer(int id, Customer c)
        {
            throw new NotImplementedException();
        }
    }
}
