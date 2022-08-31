using Core.DataAccess.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstarct
{
  public interface IBrandService
  {
    IDataResult<List<Brand>> GetAll();
    IResult Add(Brand brand);
    IResult Delete(Brand brand);
    IResult Update(Brand brand);
  }
}
