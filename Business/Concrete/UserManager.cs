﻿using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class UserManager:IUserService
    {
        readonly IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public IResult Add(User user)
        {
            ValidationTool.Validate(new UserValidator(), user);

            _userDal.Add(user);
            return new SuccessResult(Messages.UserAdded);
        }

        public IResult Delete(User user)
        {
            ValidationTool.Validate(new UserValidator(), user);

            _userDal.Delete(user);
            return new SuccessResult(Messages.UserDeleted);
        }

        public IDataResult<List<User>> GetAll()
        {
            var getAll = _userDal.GetAll();
            return new SuccessDataResult<List<User>>(getAll);
        }

        public IDataResult<User> GetById(int userId)
        {
            var getById = _userDal.Get(u => u.Id == userId);
            return new SuccessDataResult<User>(getById);
        }

        public IResult Update(User user)
        {
            ValidationTool.Validate(new UserValidator(), user);

            _userDal.Update(user);
            return new SuccessResult(Messages.UserUpdated);
        }
    }
}
