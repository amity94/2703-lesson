using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2703hw
{
    public class Customer
    {
        public int Id;
        public string FirstName;
        public string LastName;
        public int Age;
        public string AddressCity;
        public string AddressStreet;
        public string PhNumber;

        public Customer()
        {

        }

        public override string ToString()
        {
            return $"Customer {Id}, Name: {FirstName + LastName}, Age: {Age}, Address: {AddressCity + "-" + AddressStreet}" +
                $"Phone Number: {PhNumber}";
        }
    }
}
