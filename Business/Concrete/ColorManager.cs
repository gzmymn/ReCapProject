﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Business.Constants;
using Core.Aspects.Autofac.Validation;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        [CacheRemoveAspect("IColorService.Get")]
        [ValidationAspect(typeof(ColorValidator))]        
        public IResult Add(Color color)
        {
           _colorDal.Add(color);
            return new SuccessResult(Messages.ColorAdded);
        }

        
        [CacheRemoveAspect("IColorService.Get")]
        public IResult Delete(Color color)
        {
            _colorDal.Delete(color);
            return new SuccessResult(Messages.ColorDeleted);
        }

        [CacheAspect]
        public IDataResult<List<Color>> GetAll()
        {
            return new SuccessDataResult<List<Color>>( _colorDal.GetAll(), Messages.ColorsListed);
        }

        [CacheAspect]
        public IDataResult<Color> GetById(int colorId)
        {
            return new SuccessDataResult<Color>(_colorDal.Get(c=>c.ColorId==colorId));
        }

        [ValidationAspect(typeof(ColorValidator))]
        [CacheRemoveAspect("IColorService.Get")]
        public IResult Update(Color color)
        {
             _colorDal.Update(color);
            return new SuccessResult(Messages.ColorUpdated);
        }
    }
}
