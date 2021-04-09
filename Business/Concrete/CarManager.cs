﻿using Business.Abstract;
using Business.Constants;
using DataAccess.Abstract;
using Core.Utilities.Results;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.CrossCuttingConcerns.Validation;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Business.BusinessAspects.Autofac;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Transaction;
using Core.Aspects.Autofac.Performance;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        readonly ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        [SecuredOperation("car.add,admin")]
        [ValidationAspect(typeof(CarValidator))]
        [CacheRemoveAspect("ICarService.Get")]
        public IResult Add(Car car)
        {

            _carDal.Add(car);
            return new SuccessResult(Messages.CarAdded);
        }

        [ValidationAspect(typeof(CarValidator))]
        [TransactionScopeAspect]
        public IResult UpdateTransactionalOperation(Car car)
        {
            _carDal.Update(car);
            if (car.DailyPrice < 80)
                throw new Exception(Messages.CarCouldntBeUpdated);

            _carDal.Update(car);
            return new SuccessResult(Messages.CarUpdated);
        }

        [CacheAspect]
        public IDataResult<Car> GetById(int carId)
        {
            var getById = _carDal.Get(c => c.Id == carId);
            return new SuccessDataResult<Car>(getById);
        }

        [CacheAspect(duration: 10)]
        [PerformanceAspect(5)]
        public IDataResult<List<Car>> GetAll()
        {
            var getAll = _carDal.GetAll();
            return new SuccessDataResult<List<Car>>(getAll);
        }

        [CacheAspect]
        public IDataResult<List<Car>> GetCarsByBrandId(int brandId)
        {
            var getCarsByBrandId = _carDal.GetAll(c => c.BrandId == brandId);
            return new SuccessDataResult<List<Car>>(getCarsByBrandId);
        }

        public IDataResult<List<Car>> GetCarsByColorId(int colorId)
        {
            var getCarsByColorId = _carDal.GetAll(c => c.ColorId == colorId);
            return new SuccessDataResult<List<Car>>(getCarsByColorId);
        }

        [SecuredOperation("car.update,admin")]
        [ValidationAspect(typeof(CarValidator))]
        [CacheRemoveAspect("ICarService.Get")]
        public IResult Update(Car car)
        {

            _carDal.Update(car);
            return new SuccessResult(Messages.CarUpdated);
        }

        [SecuredOperation("car.delete,admin")]
        [ValidationAspect(typeof(CarValidator))]
        [CacheRemoveAspect("ICarService.Get")]
        public IResult Delete(Car car)
        {

            _carDal.Delete(car);
            return new SuccessResult(Messages.CarDeleted);
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            var getCarDetails = _carDal.GetCarDetails();
            return new SuccessDataResult<List<CarDetailDto>>(getCarDetails);
        }
    }
}