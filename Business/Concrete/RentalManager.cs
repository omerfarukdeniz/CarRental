using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        private IRentalDal _rentalDal;
        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }
        public IResult Add(Rental rental)
        {
            rental.IsDelivered = false;
            _rentalDal.Add(rental);
            return new SuccessResult(RentalMessages.SuccessRentCar);
        }
        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult();
        }
        public IResult Delete(int rentalId)
        {
            _rentalDal.Delete(new Rental { Id = rentalId });
            return new SuccessResult();
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll());
        }

        public IDataResult<Rental> GetRentalById(int rentalId)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(r => r.Id == rentalId));
        }
        public IDataResult<List<Rental>> GetRentalsByCustomerId(int customerId)
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(r => r.CustomerId == customerId));
        }
    }
}
