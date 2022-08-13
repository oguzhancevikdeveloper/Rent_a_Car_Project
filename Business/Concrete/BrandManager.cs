using Business.Abstarct;
using Business.Constant;
using Core.DataAccess.Utilities.Results;
using DataAccess.Abstarct;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
  public class BrandManager : IBrandService
  {
    IBrandDal _brandDal;
    public BrandManager(IBrandDal brandDal)
    {
      _brandDal = brandDal;
    }
    public IResult AddCar(Brand brand)
    {
      _brandDal.Add(brand);
      return new SuccessResult(Messages.CarAdded);
    }
    public IResult Delete(Brand brand)
    {
      _brandDal.Delete(brand);
      return new SuccessResult(Messages.CarDeleted);
    }
    public IDataResult<List<Brand>> GetAll()
    {
      return new SuccessDataResult<List<Brand>> (_brandDal.GetAll(),Messages.CarListed);
    }
    public IResult Update(Brand brand)
    {
      _brandDal.Update(brand);
      return new SuccessResult(Messages.CarAdded);
    }
  }
}
