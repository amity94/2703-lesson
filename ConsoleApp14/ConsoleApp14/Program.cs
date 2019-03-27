using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp14
{
    class Program
    {

        static void Main(string[] args)
        {
            List<Shopping> shopping = new List<Shopping>();
            
            // connect to the Data Base
            using (SQLiteConnection con = new SQLiteConnection($@"Data Source = C:\Users\HackerU\Desktop\hw2403.db; Version = 3;"))
            {
                // open the connection
                con.Open();
                // create a query (suign the connection)
                using (SQLiteCommand cmd = new SQLiteCommand("SELECT * From shopping ", con))
                {
                    // execut4e the query into the reader
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        // use the reader to read all of the results of the query
                        while (reader.Read())
                        {
                            Shopping s = new Shopping
                            {
                                Id = (Int32)reader["id"],
                                Name = (string)reader["name"],
                                Amount = (Int32)reader["amount"],
                                Maavar = (Int32)reader["maavar"]
                            };
                            shopping.Add(s);
                            // pull out the data result using GetValue for dield number
                            Console.WriteLine(
                                $"{reader["id"]}, {reader["name"]}, {reader["amount"]}, {reader["maavar"]}");
                        }
                    }
                }
                Console.WriteLine("!==================================!");
                foreach(var s in shopping)
                    Console.WriteLine(s);
                Console.WriteLine();
            }
        }
    }
}