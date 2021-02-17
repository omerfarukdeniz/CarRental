using Business.Abstract;
using Business.Constants;
using Core.Utilities;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;
        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }
        public IResult Add(Color color)
        {
            _colorDal.Add(color);
            return new SuccessResult(ColorMessages.ColorAdded);
        }
        public IResult Update(Color color)
        {
            _colorDal.Update(color);
            return new SuccessResult();
        }
        public IResult Delete(int colorID)
        {
            _colorDal.Delete(new Color { ID = colorID });
            return new SuccessResult();
        }

        public IDataResult<List<Color>> GetAll()
        {
            return new SuccessDataResult<List<Color>>(_colorDal.GetAll());
        }

        public IDataResult<Color> GetById(int colorID)
        {
            return new SuccessDataResult<Color>(_colorDal.Get(c => c.ID == colorID));
        }

        
    }
}
