﻿using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        IResult Add(Customer customer);
        IResult Update(Customer customer);
        IResult Delete(int customerId);
        IDataResult<List<Customer>> GetAll();
        IDataResult<Customer> GetCustomerById(int customerId);
        IDataResult<List<Customer>> GetCustomersByUserId(int userId);
    }
}
