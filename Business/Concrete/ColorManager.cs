﻿using Business.Abstarct;
using Business.Constant;
using Core.DataAccess.Utilities.Results;
using DataAccess.Abstarct;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
  public class ColorManager : IColorService
  {
    IColorDal _colorDal;
    public ColorManager(IColorDal colorDal)
    {
      _colorDal = colorDal;
    }
    public IResult AddCar(Color color)
    {
      _colorDal.Add(color);
      return new SuccessResult(Messages.ColorAdded);
    }
    public IResult Delete(Color color)
    {
      _colorDal.Delete(color);
      return new SuccessResult(Messages.ColorDeleted);
    }
    public IDataResult<List<Color>> GetAll()
    {
      return new SuccessDataResult<List<Color>>(_colorDal.GetAll());
    }
    public IResult Update(Color color)
    {
      _colorDal.Update(color);
      return new SuccessResult(Messages.ColorUpdated);
    }
  }
}
