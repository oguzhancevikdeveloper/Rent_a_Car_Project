using Business.Abstarct;
using Business.Constant;
using Core.DataAccess.Utilities.Results;
using DataAccess.Abstarct;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
  public class CarManager : ICarService
  {
    ICarDal _carDal;

    public CarManager(ICarDal carDal)
    {
      _carDal = carDal;
    }
    public IResult AddCar(Car car)
    {
       _carDal.Add(car);
      return new SuccessResult(Messages.CarAdded);
    }
    public IResult Delete(Car car)
    {
      _carDal.Delete(car);
      return new SuccessResult(Messages.CarDeleted);
    }
    public IResult Update(Car car)
    {
      _carDal.Update(car);
      return new SuccessResult(Messages.CarUpdated);
    }
    public IDataResult<List<Car>> GetAll()
    {
      return new SuccessDataResult<List<Car>> (_carDal.GetAll());
    }
    public IDataResult<List<Car>> GetCarsByBrandId(int brandId)
    {
      return new SuccessDataResult<List<Car>> (_carDal.GetCarsByBrandId(brandId));
    }
    public IDataResult<List<Car>> GetCarsByColorId(int colorId)
    {
      return new SuccessDataResult<List<Car>> (_carDal.GetCarsByColorId(colorId));
    }
  }
}
