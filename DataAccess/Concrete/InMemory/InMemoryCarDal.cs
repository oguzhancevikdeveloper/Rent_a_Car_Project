using Entities.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concrete.InMemory
{
  public class InMemoryCarDal 
  {
    List<Car> _car;
    public InMemoryCarDal()
    {
      _car = new List<Car>
        {
          new Car { Id=1, BrandId=1, ColorId=1, DailyPrice=100, Description="Happy", ModelYear="2022"}
    };
    }
    public void Add(Car car)
    {
      _car.Add(car);
    }
    public void Delete(Car car)
    {
      Car deleteCar = _car.SingleOrDefault(x => x.Id == car.Id);
      _car.Remove(deleteCar);
    }
    public List<Car> GetAll()
    {
      return _car;
    }
    public List<Car> GetAllById(Car car)
    {
      return _car.Where(x => x.Id == car.Id).ToList();
    }
    public void Update(Car car)
    {
      Car updateCar = _car.SingleOrDefault(x => x.Id == car.Id);
      updateCar.Id = car.Id;
      updateCar.BrandId = car.BrandId;
      updateCar.ColorId = car.ColorId;
      updateCar.DailyPrice = car.DailyPrice;
      updateCar.ModelYear = car.ModelYear;
      updateCar.Description = car.Description;
    }
  }
}
