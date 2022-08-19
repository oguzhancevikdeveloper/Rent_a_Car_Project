﻿using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Core.DataAccess.EtityFramework
{
  public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity> where TEntity : class, IEntity, new() where TContext : DbContext, new()
  {
    public void Add(TEntity entity)
    {
      using (TContext context = new TContext())
      {
        var addedEntity = context.Entry(entity);
        addedEntity.State = EntityState.Added;
        context.SaveChanges();
      }
      Console.WriteLine("Ekleme işlemi başarı ile gerçekleşti");
    }
    public void Delete(TEntity entity)
    {
      using (TContext context = new TContext())
      {
        var deletedEntity = context.Entry(entity);
        deletedEntity.State = EntityState.Deleted;
        context.SaveChanges();
      }
      Console.WriteLine("Silme işlmei başarı ile gerçekleşti");
    }
    public TEntity Get(Expression<Func<TEntity, bool>> filter)
    {
      using (TContext context = new TContext())
      {
        return context.Set<TEntity>().SingleOrDefault(filter);
      }
    }
    public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
    {
      using (TContext context = new TContext())
      {
        return filter == null ? context.Set<TEntity>().ToList() : context.Set<TEntity>().Where(filter).ToList();
      }
    }
    public void Update(TEntity entity)
    {
      using (TContext context = new TContext())
      {
        var updateddEntity = context.Entry(entity);
        updateddEntity.State = EntityState.Modified;
        context.SaveChanges();
      }
    }
  }
}
