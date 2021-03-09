using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.CustomerId = 1;
            customer1.CustomerName = "Çetin";
            customer1.CustomerSurname = "Ürün";

            Customer customer2 = new Customer();
            customer2.CustomerId = 2;
            customer2.CustomerName = "Vedat";
            customer2.CustomerSurname = "Kaya";

            Customer customer3 = new Customer();
            customer3.CustomerId = 3;
            customer3.CustomerName = "Hacı Ahmet";
            customer3.CustomerSurname = "Karadağ";

            Customer[] customers = new Customer[] { customer1, customer2, customer3 };

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer2);
            customerManager.Delete(customer3);
            customerManager.CustomerList(customer1);
            

        }
    }
}
