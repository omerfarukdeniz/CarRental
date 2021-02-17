using Business.Abstract;
using Business.Constants;
using Core.Utilities;
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
        public IResult Add(Car car)
        {
            if (car.CarName.Length<2)
            {
                return new ErrorResult();
            }
            _carDal.Add(car);
            return new SuccessResult();
        }
        public IResult Update(Car car)
        {
            if (car.CarName.Length < 2)
            {
                return new ErrorResult();
            }
            _carDal.Update(car);
            return new SuccessResult();
        }
        public IResult Delete(int carID)
        {
            _carDal.Delete(new Car { ID = carID });
            return new SuccessResult();
        }

        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>( _carDal.GetAll());
        }

        public IDataResult<Car> GetById(int carID)
        {
            return new SuccessDataResult<Car>(_carDal.Get(c => c.ID == carID));
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails());
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int brandId)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(b => b.BrandID == brandId));
        }

        public IDataResult<List<Car>> GetCarsByColorId(int colorId)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.ColorID == colorId));
        }
    }
}
