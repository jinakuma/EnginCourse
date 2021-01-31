using System;
using AbstractClassDemo.Abstract;

using AbstractClassDemo.Concrete;
using AbstractClassDemo.Entities;

namespace AbstractClassDemo
{
    partial class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new NeroCustomerManager();
            customerManager.Save(new Customer { DateOfBirth = new DateTime(1984, 12, 7), FirstName = "Murat", LastName = "UTLU", NationalityId = "61252319098" });
        }    
    }
}
