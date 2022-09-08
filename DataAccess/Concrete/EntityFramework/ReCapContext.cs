using Core.Entities.Concrete;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete
{
  public class ReCapContext : DbContext
  {
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
     // optionsBuilder.UseSqlServer(@"Server=DESKTOP-801UGNA\SQLEXPRESS;Database=ReCarDb;Trusted_Connection=true");
      optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=ReCarDb;Trusted_Connection=true");
    }
    public DbSet<Brand> Brands { get; set; }
    public DbSet<Car> Cars { get; set; }
    public DbSet<Color> Colors { get; set; }
    public DbSet<OperationClaim> OperationClaims { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<UserOperationClaim> UsersOperationClaims { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Rental> Rentals { get; set; }
    public DbSet<CarImage> CarImages { get; set; }
  }
}
