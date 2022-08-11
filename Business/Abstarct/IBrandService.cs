using Core.DataAccess.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstarct
{
  public interface IBrandService
  {
    IDataResult<List<Brand>> GetAll();
    IResult AddCar(Brand brand);
    IResult Delete(Brand brand);
    IResult Update(Brand brand);
  }
}
