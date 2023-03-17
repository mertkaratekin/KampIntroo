using System;

namespace Classes
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();
            
            ProductManager productManager = new ProductManager();
            productManager.Add();   
            productManager.Update();

            Customer customer1 = new Customer() { Id = 1,
                FirstName = "Engin", LastName = "Demiroğ",City="Ankara"};

            Console.WriteLine(customer1.FirstName);
        }

    }
}