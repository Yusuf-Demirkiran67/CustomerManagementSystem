using CustomerManager.Abstract;
using CustomerManager.Adapters;
using CustomerManager.Concrete;
using CustomerManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManager
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer
            {
                DateOfBirth = new DateTime(2001, 2, 1),
                FirstName="Yusuf",
                LastName="Demirkıran",
                NationalityId="12345678912"
            });
            Console.ReadLine();
        }
    }

  
}
