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
    public class EfCarDal : EfEntityRepositoryBase<Car, CarRentalContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                var result = from car in context.Cars
                             join color in context.Colors on car.ColorID equals color.ID
                             join brand in context.Brands on car.BrandID equals brand.ID
                             select new CarDetailDto
                             {
                                 CarID = car.ID,
                                 CarName = car.CarName,
                                 DailyPrice = car.DailyPrice,
                                 BrandName = brand.BrandName,
                                 ColorName = color.ColorName
                             };
                return result.ToList();
            }
        }
    }
}
