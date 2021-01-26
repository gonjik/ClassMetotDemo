using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer()
            {
                ID = 110,
                Name = "Mark",
                Salary = 5000,
            };

            Customer customer2 = new Customer()
            {
                ID = 120,
                Name = "Joe",
                Salary = 6500,
            };

            Customer customer3 = new Customer()
            {
                ID = 130,
                Name = "Dou",
                Salary = 3500,
            };

            Dictionary<int, Customer> dictionaryCustomers = new Dictionary<int, Customer>();
            dictionaryCustomers.Add(customer1.ID, customer1);
            dictionaryCustomers.Add(customer2.ID, customer2);
            dictionaryCustomers.Add(customer3.ID, customer3);

            Customer customer110 = dictionaryCustomers[110];
            // Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}",customer110.ID, customer110.Name, customer110.Salary);
            foreach (KeyValuePair<int, Customer> customerkeyValuePair in dictionaryCustomers)
            {
                Console.WriteLine("ID = {0}", customerkeyValuePair.Key);
                Customer cust1 = customerkeyValuePair.Value;
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", cust1.ID, cust1.Name, cust1.Salary);
                Console.WriteLine("----------------");
                    
            }


            // TryGetValue
            Customer cust;
            if (dictionaryCustomers.TryGetValue(110, out cust))
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", cust.ID, cust.Name, cust.Salary);
            }
            else
            {
                Console.WriteLine("The key is not found");
            }

            //Count toplam elemanı yazar.  (3)

            Console.WriteLine("Total Items = {0}", dictionaryCustomers.Count);

            //Remove siler. 
            //dictionaryCustomers.Remove(120);
            //Console.WriteLine(dictionaryCustomers.Count);

            //Clear
            //dictionaryCustomers.Clear();
            //Console.WriteLine(dictionaryCustomers.Count);

 
        }
    }

    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
}


