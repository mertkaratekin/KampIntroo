using System;

namespace Interfaces
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            /*PersonManager manager = new PersonManager();
            Customer customer1 = new Customer()
            {
                Id = 1,
                FirstName = "Engin",
                LastName = "Demiroğ",
                Address = "Ankara"
            };
            manager.Add(customer1);
            Student student1 = new Student() {Id=2,FirstName="Derin",
            LastName="Demiroğ",Dpartment="ComputerScience"};

            manager.Add(student1);
            */
            ICustomerDal OracleServerCustomerDal = new OracleServerCustomerDal();
            ICustomerDal SqlServerCustomerDal = new SqlServerCustomerDal();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(OracleServerCustomerDal);
            customerManager.Delete(OracleServerCustomerDal);
            customerManager.Update(SqlServerCustomerDal);
            Console.WriteLine("*************************");
            
            //ICustomerDal[] customerDals = new[] {SqlServerCustomerDal,OracleServerCustomerDal };
            List<ICustomerDal> customerDals = new List<ICustomerDal>() {SqlServerCustomerDal,OracleServerCustomerDal};
            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }

        }
        interface IPerson
        {
            int Id { get; set; }
            string FirstName { get; set; }
            string LastName { get; set; }
        }
        class Customer : IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Address { get; set; }
        }
        class Student : IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Dpartment { get; set; }
        }
        class PersonManager
        {
            public void Add(IPerson person)
            {
                Console.WriteLine(person.FirstName+" eklendi.");
            }
        }
    }
}