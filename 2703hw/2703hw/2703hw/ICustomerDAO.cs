using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2703hw
{
    interface ICustomerDAO
    {
        List<Customer> GetAllCustomers();
        Customer GetCustomerById(int id);
        void AddCustomer(Customer c);
        void UpdateCustomer(int id, Customer c);
        void DeleteCustomer(int id);
        List<Customer> GetCustomerLivingInCity(string city);
        List<Customer> GetCustomerBetweenAges(int minAge, int maxAge);
        Customer GetCustomerByPhoneNumber(string phone);
        void RemoveAllCustomers();
    }
}
