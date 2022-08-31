using Business.Abstarct;
using Business.Constant;
using Core.DataAccess.Utilities.Results;
using DataAccess.Abstarct;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
  public class CarImageManager : ICarImageService
  {
    ICarImageDal _carImageDal;

    public CarImageManager(ICarImageDal carImageDal)
    {
      _carImageDal = carImageDal;
    }

    public IResult Add(CarImage carImage)
    {
   
      _carImageDal.Add(carImage);
      return new SuccessResult();
    }

    public IDataResult<List<CarImage>> GetAll()
    {
      return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll(),Messages.GetAllCarImage);
    }
  }
}
