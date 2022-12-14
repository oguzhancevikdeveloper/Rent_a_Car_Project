using Core.DataAccess.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstarct
{
  public interface ICarService
  {
    IDataResult<List<Car>> GetAll();
    IDataResult<List<Car>> GetCarsByBrandId(int brandId);
    IDataResult<List<Car>> GetCarsByColorId(int colorId);
    IResult AddCar(Car car);
    IResult Delete(Car car);
    IResult Update(Car car);

  }
}
