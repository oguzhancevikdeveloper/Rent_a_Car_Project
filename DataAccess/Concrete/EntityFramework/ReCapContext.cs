using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete
{
  public class ReCapContext: DbContext
  {
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseSqlServer(@"Server=DESKTOP-801UGNA\SQLEXPRESS;Database=ReCarDb;Trusted_Connection=true");
      // optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=ReCapDb;Trusted_Connection=true");
    }

    public DbSet<Brand> Brands { get; set; }
    public DbSet<Car> Cars { get; set; }
    public DbSet<Color> Colors { get; set; }
  }
}
