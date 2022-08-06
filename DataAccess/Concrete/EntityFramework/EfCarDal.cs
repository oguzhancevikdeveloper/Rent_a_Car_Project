using DataAccess.Abstarct;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
  public class EfCarDal : ICarDal
  {
    public void Add(Car entity)
    {
      using (ReCapContext context = new ReCapContext())
      {
        if(entity.CarName.Length > 2 && entity.DailyPrice>0)
        {
          var addedEntity = context.Entry(entity);
          addedEntity.State = EntityState.Added;
          context.SaveChanges();
        }
        else
        {
          Console.WriteLine("Araba ismi minimum 2 karakter olmalıdır ve Araba günlük fiyatı 0'dan büyük olmalıdır.");
        }
      }
    }

    public void Delete(Car entity)
    {
      using (ReCapContext context = new ReCapContext())
      {
        var deletedEntity = context.Entry(entity);
        deletedEntity.State = EntityState.Deleted;
        context.SaveChanges();
      }
    }

    public Car Get(Expression<Func<Car, bool>> filter)
    {
      using (ReCapContext context = new ReCapContext())
      {
        return context.Set<Car>().SingleOrDefault(filter);
      }
    }

    public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
    {
      using (ReCapContext context = new ReCapContext())
      {
        return filter == null ? context.Set<Car>().ToList() : context.Set<Car>().Where(filter).ToList();
      }
    }

    public List<Car> GetCarsByBrandId(int brandId)
    {
      using (ReCapContext context = new ReCapContext())
      {
        return context.Set<Car>().Where(x => x.BrandId == brandId).ToList();
      }
    }

    public List<Car> GetCarsByGetCarsByColorId(int colorId)
    {
      using (ReCapContext context = new ReCapContext())
      {
        return context.Set<Car>().Where(x => x.ColorId == colorId
        ).ToList();
      };
    }

    public void Update(Car entity)
    {
      using (ReCapContext context = new ReCapContext())
      {
        var updateddEntity = context.Entry(entity);
        updateddEntity.State = EntityState.Modified;
        context.SaveChanges();
      }
    }
  }
}
