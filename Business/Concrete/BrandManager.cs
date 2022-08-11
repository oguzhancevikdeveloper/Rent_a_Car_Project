using Business.Abstarct;
using Core.DataAccess.Utilities.Results;
using DataAccess.Abstarct;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

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
      return
    }

    public IResult Delete(Brand brand)
    {
      _brandDal.Delete(brand);
    }

    public IDataResult<List<Brand>> GetAll()
    {
      return new SuccessDataResult<List<Brand>> (_brandDal.GetAll());
    }

    public IResult Update(Brand brand)
    {
      _brandDal.Update(brand);
    }
  }
}
