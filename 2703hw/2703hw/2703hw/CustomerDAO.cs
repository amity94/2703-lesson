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
            using (SQLiteConnection con = new SQLiteConnection($@"Data Source = C:\Users\HackerU\Desktop\hw2703.db; Version = 3;"))
            {
                con.Open(); 

                using (SQLiteCommand cmd = new SQLiteCommand($"INSERT INTO Customer VALUES ({c.Id},'{c.FirstName}','{c.LastName}'," +
                    $"{c.Age},'{c.AddressCity}','{c.AddressStreet}','{c.PhNumber}')", con))
                {
                    cmd.ExecuteNonQuery();
                }
            }
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
            using (SQLiteConnection con = new SQLiteConnection($@"Data Source = C:\Users\HackerU\Desktop\hw2703.db; Version = 3;"))
            {
                using (SQLiteCommand cmd = new SQLiteCommand($"update customer set(ID = {c.Id}, FIRST_NAME ='{c.FirstName}', LAST_NAME = '{c.LastName}'," +
                    $" AGE = {c.Age}, ADDRESS_CITY = '{c.AddressCity}', ADDRESS_STREET = '{c.AddressStreet}', PH_NUMBER = '{c.PhNumber}' where ID ={id}", con))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
