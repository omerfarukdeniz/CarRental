﻿using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        void Add(Car car);
        void Update(Car car);
        void Delete(int carID);
        List<Car> GetAll();
        Car GetById(int carID);
        List<CarDetailDto> GetCarDetails();

    }
}