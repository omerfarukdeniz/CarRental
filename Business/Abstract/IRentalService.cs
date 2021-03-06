﻿using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IResult Add(Rental rental);
        IResult Update(Rental rental);
        IResult Delete(int rentalId);
        IDataResult<List<Rental>> GetAll();
        IDataResult<Rental> GetRentalById(int rentalId);
        IDataResult<List<Rental>> GetRentalsByCustomerId(int customerId);
        IDataResult<List<RentalDetailDto>> GetRentalDetails();
    }
}
