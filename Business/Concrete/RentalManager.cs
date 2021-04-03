﻿using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager:IRentalService
    {
        readonly IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IResult Add(Rental rental)
        {
            var rentalsReturnDate = _rentalDal.GetAll(r => r.CarId == rental.CarId);

            if (rentalsReturnDate.Count > 0)
            {
                foreach (var rentalReturnDate in rentalsReturnDate)
                {
                    if (rentalReturnDate.ReturnDate == null)
                    {
                        return new ErrorResult(Messages.RentalReturnDateIsNull);
                    }
                }
            }

            _rentalDal.Add(rental);
            return new SuccessResult(Messages.RentalAdded);
        }

        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult(Messages.RentalDeleted);
        }

        public IDataResult<List<Rental>> GetAll()
        {
            var getAll = _rentalDal.GetAll();
            return new SuccessDataResult<List<Rental>>(getAll);
        }

        public IDataResult<Rental> GetById(int rentalId)
        {
            var getById = _rentalDal.Get(u => u.Id == rentalId);
            return new SuccessDataResult<Rental>(getById);
        }

        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult(Messages.RentalUpdated);
        }
    }
}
