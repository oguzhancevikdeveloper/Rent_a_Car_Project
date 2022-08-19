using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
  class Program
  {
    static void Main(string[] args)
    {
      //CarTest();
      //UserTest();
      //RentTest();
      UserUpdate();
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
    public static void RentTest()
    {
      RentalManager rentalManager = new RentalManager(new EfRentalDal());
      CarManager carManager = new CarManager(new EfCarDal());
      UserManager userManager = new UserManager(new EfUserDal());
      Console.WriteLine("Araç kiralamaya hoşgeldiniz!");
      Console.WriteLine("Lütfen İstenilen Bilgeleri doldurunuz...");
      User user = new User();

      Console.Write("İsminiz: ");
      user.FirstName = Console.ReadLine();
      Console.Write("Soyisminiz: ");
      user.LastName = Console.ReadLine();
      Console.Write("Email: ");
      user.Email = Console.ReadLine();
      Console.Write("Password: ");
      user.Password = Console.ReadLine();

      userManager.AddUser(user);

      


      Console.WriteLine("Araba Kiralama İçin Hoşgeldiniz!");
      Console.WriteLine("Lütfen kiralamak istediğiniz arabayı numara olarak seçiniz");

      foreach (var car in carManager.GetAll().Data)
      {
        Console.WriteLine(car.CarName + " = " + car.Id);
      }
      Console.WriteLine("Lütfen Seçim Yapınız: ");
      int secim = Convert.ToInt32(Console.ReadLine());

      Rental rental = new Rental();
      rental.CarId = secim;
      rental.RentDate = DateTime.Now;
      rental.RentDate = Convert.ToDateTime("02-09-1999");
      rental.CustomerId = 11;


    }
    public static void UserUpdate()
    {
      UserManager userManager = new UserManager(new EfUserDal());
      User user1 = new User();
      user1.Id = 1;
      user1.FirstName = "Oguzhan";
      user1.LastName = "Cevikkk";
      user1.Email = "oguzhancevikkk@gmail.com";
      user1.Password = "132456";
      userManager.Update(user1);

   

    }
  }
}
