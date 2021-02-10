using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        private ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }
        public void Add(Car car)
        {
            _carDal.Add(car);
        }
        public void Update(Car car)
        {
            _carDal.Update(car);
        }
        public void Delete(int carID)
        {
            _carDal.Delete(new Car { ID = carID });
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public Car GetById(int carID)
        {
            return _carDal.Get(c => c.ID == carID);
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _carDal.GetCarDetails();
        }
    }
}
