using System;
using System.Collections.Generic;
using System.Text;
using AbstractClassDemo.Abstract;
using AbstractClassDemo.Entities;

namespace AbstractClassDemo.Abstract
{
    public interface ICustomerService
    {
        void Save(Customer costumer);
    }
}
