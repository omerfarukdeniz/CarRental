﻿using Core.Utilities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IColorService
    {
        IResult Add(Color color);
        IResult Update(Color color);
        IResult Delete(int colorID);
        IDataResult<List<Color>> GetAll();
        IDataResult<Color> GetById(int colorID);
    }
}
