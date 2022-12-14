using Core.DataAccess.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstarct
{
  public interface IRentalService
  {
    IDataResult<List<Rental>> GetAll();
    IResult Add(Rental rental);
    IResult Delete(Rental rental);
    IResult Update(Rental rental);
  }
}
