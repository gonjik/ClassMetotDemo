using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer {Id=1, Firstname = "Engin", Lastname="Demiroğ", City="Ankara" };

            Customer customer2 = new Customer (2, "Derin", "Demiroğ", "Ankara" );
        }
    }

    class Customer
    {
        public Customer()
        {

        }
        public Customer(int id, string firstname, string lastname, string city)
        {
            Console.WriteLine("Yapıcı Blok Çalıştı.");
        }
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string City { get; set; }
    }
}
