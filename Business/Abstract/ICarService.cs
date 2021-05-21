﻿using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<CarDetailDto> GetById(int carId);
        IDataResult<List<Car>> GetAll();
        IDataResult<List<CarDetailDto>> GetCarsByBrandId(int brandId);
        IDataResult<List<CarDetailDto>> GetCarsByColorId(int colorId);
        IDataResult<List<CarDetailDto>> GetCarDetails();
        IDataResult<List<CarDetailDto>> GetCarDetailsByFilter(CarDetailFilterDto carDetailFilterDto);

        IResult Add(Car car);
        IResult Update(Car car);
        IResult Delete(Car car);

        IResult UpdateTransactionalOperation(Car car);
    }
}