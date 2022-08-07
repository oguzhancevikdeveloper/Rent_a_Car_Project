using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
  class Program
  {
    static void Main(string[] args)
    {
      CarManager carManager = new CarManager(new EfCarDal());

      Car car1 = new Car();
      car1.CarName = "BMW";
      car1.BrandId = 1;
      car1.ColorId = 1;
      car1.DailyPrice = 100;
      car1.Description = "Hello";
      car1.Id = 1;
      car1.ModelYear = "1999";

      carManager.AddCar(car1);

    }
  }
}
