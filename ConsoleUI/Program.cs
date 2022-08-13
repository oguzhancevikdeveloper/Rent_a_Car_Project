using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsoleUI
{
  class Program
  {
    static void Main(string[] args)
    {
      //CarTest();
      //UserTest();
    }
    public static void CarTest()
    {
      CarManager carManager = new CarManager(new EfCarDal());

      var result = carManager.GetAll();

      if (result.Success == true)
      {
        foreach (var car in result.Data)
        {
          Console.WriteLine(car.CarName + " / " + car.DailyPrice);
        }
      }
      else
      {
        Console.WriteLine(result.Message);
      }
    }
    public static void UserTest()
    {
      UserManager userManager = new UserManager(new EfUserDal());

      var result = userManager.GetAll();

      if (result.Success == true)
      {
        foreach (var user in result.Data)
        {
          Console.WriteLine(user.FirstName + " / " + user.LastName);
        }
      }
      else
      {
        Console.WriteLine(result.Message);
      }
    }
  }
}
