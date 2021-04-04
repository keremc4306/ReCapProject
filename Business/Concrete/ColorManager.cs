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
    public class ColorManager : IColorService
    {
        readonly IColorDal _colorDal;
        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public IResult Add(Color color)
        {
            ValidationTool.Validate(new ColorValidator(), color);

            _colorDal.Add(color);
            return new SuccessResult(Messages.ColorAdded);
        }

        public IResult Delete(Color color)
        {
            ValidationTool.Validate(new ColorValidator(), color);

            _colorDal.Delete(color);
            return new SuccessResult(Messages.ColorDeleted);
        }

        public IDataResult<List<Color>> GetAll()
        {
            var getAll = _colorDal.GetAll();
            return new SuccessDataResult<List<Color>>(getAll);
        }

        public IDataResult<Color> GetById(int colorId)
        {
            var getById = _colorDal.Get(c => c.Id == colorId);
            return new SuccessDataResult<Color>(getById);
        }

        public IResult Update(Color color)
        {
            ValidationTool.Validate(new ColorValidator(), color);

            _colorDal.Update(color);
            return new SuccessResult(Messages.ColorUpdated);
        }
    }
}
