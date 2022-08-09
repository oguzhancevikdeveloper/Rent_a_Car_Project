using Business.Abstarct;
using DataAccess.Abstarct;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
  public class CarManager : ICarService
  {
    ICarDal _carDal;

    public CarManager(ICarDal carDal)
    {
      _carDal = carDal;
    }

    public void AddCar(Car car)
    {
       _carDal.Add(car);
    }

    public void Delete(Car car)
    {
      _carDal.Delete(car);
    }

    public List<Car> GetAll()
    {
      return _carDal.GetAll();
    }

    public List<Car> GetCarsByBrandId(int brandId)
    {
      return _carDal.GetCarsByBrandId(brandId);
    }

    public List<Car> GetCarsByColorId(int colorId)
    {
      return _carDal.GetCarsByColorId(colorId);
    }

    public void Update(Car car)
    {
       _carDal.Update(car);
    }
  }
}
