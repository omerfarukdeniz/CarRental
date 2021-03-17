using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarImageService
    {
        IResult Add(CarImage carImage, IFormFile file, string serverPath);
        IResult Update(CarImage carImage);
        IResult Delete(int carImageId);
        IDataResult<List<CarImage>> GetAll();
    }
}
