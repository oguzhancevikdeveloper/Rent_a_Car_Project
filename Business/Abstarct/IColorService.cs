using Core.DataAccess.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstarct
{
  public interface IColorService
  {
    IDataResult<List<Color>> GetAll();
    IResult AddCar(Color color);
    IResult Delete(Color color);
    IResult Update(Color color);
  }
}
