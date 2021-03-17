using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal: EfEntityRepositoryBase<Rental,CarRentalContext>,IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                var result = from rent in context.Rentals
                             join car in context.Cars on rent.CarId equals car.ID
                             join customer in context.Customers on rent.CustomerId equals customer.Id
                             join user in context.Users on customer.UserId equals user.Id
                             select new RentalDetailDto
                             {
                                 RentalId = rent.Id,
                                 CarName = car.CarName,
                                 CustomerName = user.FirstName+user.LastName,
                                 RentDate = rent.RentDate,
                                 ReturnDate = rent.ReturnDate
                             };

                return result.ToList();
            }
        }
    }
}
