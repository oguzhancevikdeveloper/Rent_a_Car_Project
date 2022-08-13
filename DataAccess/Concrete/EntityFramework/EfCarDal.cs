using Core.DataAccess.EtityFramework;
using DataAccess.Abstarct;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
  public class EfCarDal : EfEntityRepositoryBase<Car, ReCapContext>, ICarDal
  {
    public List<Car> GetCarsByBrandId(int brandId)
    {
      using (ReCapContext context = new ReCapContext())
      {
        return null;
      }
    }
    public List<Car> GetCarsByColorId(int colorId)
    {
      using (ReCapContext context = new ReCapContext())
      {
        return null;
      }
    }
    public List<CarDetailDto> GetCarsDetail(int carId)
    {
      using (ReCapContext context = new ReCapContext())
      {
        var result = from c in context.Cars
                     join co in context.Colors on c.ColorId equals co.Id
                     join b in context.Brands on co.Id equals b.Id
                     select new CarDetailDto
                     {
                       BrandName = b.Name,
                       CarName = c.CarName,
                       ColorName = co.Name,
                       DailyPrice = c.DailyPrice

                     };

        return result.ToList();
      }
    }
  }
}
