using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2703hw
{
    class Program
    {
        static void Main(string[] args)
        {
            using (SQLiteConnection con =
                new SQLiteConnection($@"Data Source = C:\Users\Amity\Desktop\לימודים\SQLite\hw2703.db; Version = 3;"))
            {
                con.Open();
                using (SQLiteCommand cmd = new SQLiteCommand("select * from customer", con))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read() == true)
                        {
                            Customer c = new Customer
                            {
                                Id = (int)reader["ID"],
                                FirstName = (string)reader["FIRST_NAME"],
                                LastName = (string)reader["LAST_NAME"],
                                Age = (int)reader["AGE"],
                                AddressCity = (string)reader["ADDRESS_CITY"],
                                AddressStreet = (string)reader["ADDRESS_STREET"],
                                PhNumber = (string)reader["PH_NUMBER"]
                            };

                            Console.WriteLine(
                                  $"{reader["ID"]}, {reader["FIRST_NAME"]}, {reader["LAST_NAME"]}, {reader["AGE"]}, " +
                                  $"{reader["ADDRESS_CITY"]}, {reader["ADDRESS_STREET"]}, {reader["PH_NUMBER"]}");
                        }
                    }
                }
            }
        }
    }
}
