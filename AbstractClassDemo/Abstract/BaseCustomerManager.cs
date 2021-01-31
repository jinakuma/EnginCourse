﻿using System;
using System.Collections.Generic;
using System.Text;
using AbstractClassDemo.Entities;

namespace AbstractClassDemo.Abstract
{
    public abstract class BaseCustomerManager:ICustomerService
    {
        public virtual void Save(Customer customer)
        {
            Console.WriteLine("Saved to Db: " + customer.FirstName);
        }

    }
}
