using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace PierresSite.Models
{
  public class PierresSiteContext : IdentityDbContext<ApplicationUser>
  {
    public DbSet<Treat> Treats { get; set; }
    public DbSet<Flavor> Flavors { get; set; }
    public DbSet<FlavorTreat> FlavorTreat { get; set; }

    public PierresSiteContext(DbContextOptions options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}
