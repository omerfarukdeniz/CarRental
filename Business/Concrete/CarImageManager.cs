using Business.Abstract;
using Core.Utilities.Business;
using Core.Utilities.ImageUpload;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarImageManager : ICarImageService
    {
        ICarImageDal _carImageDal;
        public CarImageManager(ICarImageDal carImageDal)
        {
            _carImageDal = carImageDal;
        }
        public IResult Add(CarImage carImage, IFormFile file, string serverPath)
        {
            IResult result = BusinessRules.Run();
            if (result != null)
            {
                return result;
            }
            carImage.ImagePath = ImageUploader.UploadImage(serverPath, file);
            _carImageDal.Add(carImage);
            return new SuccessResult();
        }
        public IResult Update(CarImage carImage)
        {
            _carImageDal.Update(carImage);
            return new SuccessResult();
        }
        public IResult Delete(int carImageId)
        {
            _carImageDal.Delete(new CarImage { Id = carImageId });
            return new SuccessResult();
        }

        public IDataResult<List<CarImage>> GetAll()
        {
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll());
        }

        
    }
}
