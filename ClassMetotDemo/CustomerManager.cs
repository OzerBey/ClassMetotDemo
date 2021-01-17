using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.Name + ": added to customers");
        }

        public void Delete(Customer customer)
        {
           Console.WriteLine(customer.Name + ": deleted from customers");
        }

        public void Update(Customer customer)
        {
            Console.WriteLine(customer.Name + ": customers are updated");
        }

        public void List(Customer[] customers)
        {
            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.Name + " "+ customer.Surname +" " + customer.AccountAmount+"$");
            }
            
        }

        public void FavoriteCustomerAdd(Customer customer)
        {
            Console.WriteLine(customer.Name + ": added to favorite customers");
        }

        public void FavoriteCustomerDelete(Customer customer)
        {
            Console.WriteLine(customer.Name + ": removed from favorite customers");
        }

        public void FavoriteCustomerList(Customer[] customers)
        {
            int i = 0;
            while (i<customers.Length)
            {
                Console.WriteLine(customers[i].Name + " " + customers[i].Surname + " " + customers[i].AccountAmount + "$");
                i++;
            }
        }

    }
}
