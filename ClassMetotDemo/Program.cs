using System;
using System.Collections;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Name = "Yasin";
            customer1.Surname = "Özer";
            customer1.AccountAmount = 250.5;

            Customer customer2 = new Customer();
            customer2.Name = "Özer";
            customer2.Surname = "Yasin";
            customer2.AccountAmount = 2500.5;

            Customer customer3 = new Customer();
            customer3.Name = "Zeynep Nur";
            customer3.Surname = "Özer";
            customer3.AccountAmount = 1250.4;

            Customer customer4 = new Customer();
            customer4.Name = "Yakup";
            customer4.Surname = "Atçı";
            customer4.AccountAmount = 2530.9;

            Customer customer5 = new Customer();
            customer5.Name = "Furkan";
            customer5.Surname = "Torun";
            customer5.AccountAmount = 2550.8;

            CustomerManager customerManager = new CustomerManager();
            //CRUD operations
            customerManager.Add(customer1);
            customerManager.Delete(customer2);
            customerManager.Update(customer3);
            customerManager.FavoriteCustomerAdd(customer4);
            customerManager.FavoriteCustomerDelete(customer5);



            Customer[] customers = new Customer[] { customer1, customer2, customer3, customer4, customer5 };
            Customer[] customersFavorite = new Customer[] {customer4};
            Console.WriteLine("--------Customers Lists----------");
            customerManager.List(customers);
            Console.WriteLine("--------Favorite Customers Lists--------");
            customerManager.FavoriteCustomerList(customersFavorite);



        }
    }
}
