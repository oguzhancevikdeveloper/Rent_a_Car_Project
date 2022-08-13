using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;

namespace DataAccess.Abstarct
{
  public interface ICarDal : IEntityRepository<Car>
  {
    List<Car> GetCarsByBrandId(int brandId);
    List<Car> GetCarsByColorId(int colorId);
    List<CarDetailDto> GetCarsDetail(int carId);
  }
}
