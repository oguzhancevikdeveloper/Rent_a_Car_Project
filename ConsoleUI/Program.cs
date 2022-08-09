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

      Car car = new Car();
      car.Id = 3;
      car.CarName = "A7";

      carManager.Update(car);

      

    }
  }
}
