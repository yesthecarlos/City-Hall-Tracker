using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

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
    protected override void OnModelCreating(ModelBuilder builder)
  {
     base.OnModelCreating(builder);
            builder.Ignore <IdentityUserLogin<string>>();
            builder.Ignore <IdentityUserRole<string>>();
            builder.Ignore<IdentityUserClaim<string>>();
            builder.Ignore<IdentityUserToken<string>>();
            builder.Ignore<IdentityUser<string>>();
            builder.Ignore<ApplicationUser>();

    builder.Entity<CouncilMember>()
      .HasData(
        new CouncilMember { CouncilMemberId = 1, CouncilMemberName = "Eliana Macias", CouncilMemberDistrict = 1, CouncilMemberStartDate = "January 7, 2020", CouncilMemberEndDate = "December 31, 2023" },
        new CouncilMember { CouncilMemberId = 2, CouncilMemberName = "Jason White", CouncilMemberDistrict = 2, CouncilMemberStartDate = "January 9, 2018", CouncilMemberEndDate = "December 31, 2021" },
        new CouncilMember { CouncilMemberId = 3, CouncilMemberName = "Patricia Byers", CouncilMemberDistrict = 3, CouncilMemberStartDate = "January 7, 2020", CouncilMemberEndDate = "December 31, 2023" },
        new CouncilMember { CouncilMemberId = 4, CouncilMemberName = "Kay Funk", CouncilMemberDistrict = 4, CouncilMemberStartDate = "January 9, 2018", CouncilMemberEndDate = "December 31, 2021" },
        new CouncilMember { CouncilMemberId = 5, CouncilMemberName = "Soneya Lund", CouncilMemberDistrict = 5, CouncilMemberStartDate = "January 7, 2020", CouncilMemberEndDate = "December 31, 2023" },
        new CouncilMember { CouncilMemberId = 6, CouncilMemberName = "Brad Hill", CouncilMemberDistrict = 6, CouncilMemberStartDate = "January 9, 2018", CouncilMemberEndDate = "December 31, 2021" },
        new CouncilMember { CouncilMemberId = 7, CouncilMemberName = "Holly Cousens", CouncilMemberDistrict = 7, CouncilMemberStartDate = "January 7, 2020", CouncilMemberEndDate = "December 31, 2023" }
      );
      
  }
  }
}