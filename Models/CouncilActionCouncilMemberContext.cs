using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace CityHallTracker.Models
{
  public class CityHallTrackerContext :  IdentityDbContext<ApplicationUser>
  {
  
   public virtual DbSet<CouncilAction> CouncilActions { get; set; }
   public virtual DbSet<CouncilMember> CouncilMembers { get; set; }
   public DbSet<CouncilActionCouncilMember> CouncilActionCouncilMember { get; set; }
   
    public CityHallTrackerContext(DbContextOptions options) : base(options) { }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}