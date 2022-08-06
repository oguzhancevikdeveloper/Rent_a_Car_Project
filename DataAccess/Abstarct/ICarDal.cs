using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstarct
{
  public interface ICarDal : IEntityRepository<Car>
  {
    List<Car> GetCarsByBrandId(int brandId);
    List<Car> GetCarsByGetCarsByColorId(int colorId);
  }
}
