using Business.Abstract;
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
        public void Add(Brand brand)
        {
            _brandDal.Add(brand);
        }
        public void Update(Brand brand)
        {
            _brandDal.Update(brand);
        }
        public void Delete(int brandID)
        {
            _brandDal.Delete(new Brand { ID = brandID });
        }

        public List<Brand> GetAll()
        {
            return _brandDal.GetAll();
        }

        public Brand GetById(int brandID)
        {
            return _brandDal.Get(b => b.ID == brandID);
        }


    }
}
