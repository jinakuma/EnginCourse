using AbstractClassDemo.Abstract;
using AbstractClassDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClassDemo.Concrete
{
    public class StarBucksCustomerManager : BaseCustomerManager
    {
        ICustomerCheckService customerCheckService;

        public StarBucksCustomerManager(ICustomerCheckService customerCheckService)
        {
            this.customerCheckService = customerCheckService;
        }

        public override void Save(Customer customer)
        {
            CheckIfRealPerson(customer);
            base.Save(customer);
        }

        private void CheckIfRealPerson(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}