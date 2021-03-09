using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.CustomerId + customer.CustomerName + customer.CustomerSurname + " Eklendi");
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.CustomerId + customer.CustomerName + customer.CustomerSurname + " Silindi");
        }

        public void CustomerList(Customer customer)
        {
            Console.WriteLine(customer.CustomerId + " " + customer.CustomerName + " " + customer.CustomerSurname + " Listelendi");
        }
    }
}
