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
    public class BrandManager : IBrandService
    {
        private IBrandDal _brandDal;
        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }
        public IResult Add(Brand brand)
        {
            _brandDal.Add(brand);
            return new SuccessResult(BrandMessages.BrandAdded);
        }
        public IResult Update(Brand brand)
        {
            _brandDal.Update(brand);
            return new SuccessResult(BrandMessages.BrandUpdated);
        }
        public IResult Delete(int brandID)
        {
            _brandDal.Delete(new Brand { ID = brandID });
            return new SuccessResult(BrandMessages.BrandDeleted);
        }

        public IDataResult<List<Brand>> GetAll()
        {
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll(),BrandMessages.BrandsListed);
        }

        public IDataResult<Brand> GetById(int brandID)
        {
            return new SuccessDataResult<Brand>(_brandDal.Get(b => b.ID == brandID),BrandMessages.BrandListed);
        }
    }
}
