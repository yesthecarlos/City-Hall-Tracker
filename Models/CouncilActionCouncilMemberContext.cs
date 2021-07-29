using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
// using Microsoft.AspNetCore.Identity;

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
      optionsBuilder.EnableSensitiveDataLogging();
    }
    protected override void OnModelCreating(ModelBuilder builder)
    {
      base.OnModelCreating(builder);
            // builder.Ignore <IdentityUserLogin<string>>();
            // builder.Ignore <IdentityUserRole<string>>();
            // builder.Ignore<IdentityUserClaim<string>>();
            // builder.Ignore<IdentityUserToken<string>>();
            // builder.Ignore<IdentityUser<string>>();
            // builder.Ignore<ApplicationUser>();

      builder.Entity<CouncilMember>()
        .HasData(
          new CouncilMember { CouncilMemberId = 1, CouncilMemberName = "Eliana Macias", CouncilMemberDistrict = 1, CouncilMemberStartDate = "January 7, 2020", CouncilMemberEndDate = "December 31, 2023" },
          new CouncilMember { CouncilMemberId = 2, CouncilMemberName = "Jason White", CouncilMemberDistrict = 2, CouncilMemberStartDate = "January 2, 2018", CouncilMemberEndDate = "December 31, 2021" },
          new CouncilMember { CouncilMemberId = 3, CouncilMemberName = "Patricia Byers", CouncilMemberDistrict = 3, CouncilMemberStartDate = "January 7, 2020", CouncilMemberEndDate = "December 31, 2023" },
          new CouncilMember { CouncilMemberId = 4, CouncilMemberName = "Kay Funk", CouncilMemberDistrict = 4, CouncilMemberStartDate = "January 2, 2018", CouncilMemberEndDate = "December 31, 2021" },
          new CouncilMember { CouncilMemberId = 5, CouncilMemberName = "Soneya Lund", CouncilMemberDistrict = 5, CouncilMemberStartDate = "January 7, 2020", CouncilMemberEndDate = "December 31, 2023" },
          new CouncilMember { CouncilMemberId = 6, CouncilMemberName = "Brad Hill", CouncilMemberDistrict = 6, CouncilMemberStartDate = "January 2, 2018", CouncilMemberEndDate = "December 31, 2021" },
          new CouncilMember { CouncilMemberId = 7, CouncilMemberName = "Holly Cousens", CouncilMemberDistrict = 7, CouncilMemberStartDate = "January 7, 2020", CouncilMemberEndDate = "December 31, 2023" },
          new CouncilMember { CouncilMemberId = 8, CouncilMemberName = "Kathy Coffey", CouncilMemberDistrict = 5, CouncilMemberStartDate = "January 5, 2016", CouncilMemberEndDate = "December 31, 2019" },
          new CouncilMember { CouncilMemberId = 9, CouncilMemberName = "Carmen Mendez", CouncilMemberDistrict = 3, CouncilMemberStartDate = "January 5, 2016", CouncilMemberEndDate = "December 31, 2019" },
          new CouncilMember { CouncilMemberId = 10, CouncilMemberName = "Avina Gutierrez", CouncilMemberDistrict = 1, CouncilMemberStartDate = "January 5, 2016", CouncilMemberEndDate = "December 31, 2019" },
          new CouncilMember { CouncilMemberId = 11, CouncilMemberName = "Dulce Gutierrez", CouncilMemberDistrict = 2, CouncilMemberStartDate = "January 5, 2016", CouncilMemberEndDate = "December 31, 2019" }
        );

      builder.Entity<CouncilAction>()
      .HasData(
        new CouncilAction { CouncilActionId = 1, CouncilActionTitle = "Make Kathy Coffey Mayor", CouncilActionDate = "January 2, 2018", CouncilActionTag = "Politics", CouncilActionContextLink = "https://www.seattletimes.com/seattle-news/yakima-mayor-drives-suv-into-rite-aid-building/" }
      );

      builder.Entity<CouncilActionCouncilMember>()
      .HasData(
        new CouncilActionCouncilMember { CouncilActionCouncilMemberId = 1, CouncilMemberId = 8, CouncilActionId = 1, CouncilMembersVote = "Yes" },
        new CouncilActionCouncilMember { CouncilActionCouncilMemberId = 2, CouncilMemberId = 9, CouncilActionId = 1, CouncilMembersVote = "Yes" },
        new CouncilActionCouncilMember { CouncilActionCouncilMemberId = 3, CouncilMemberId = 11, CouncilActionId = 1, CouncilMembersVote = "Yes" },
        new CouncilActionCouncilMember { CouncilActionCouncilMemberId = 4, CouncilMemberId = 4, CouncilActionId = 1, CouncilMembersVote = "Yes" },
        new CouncilActionCouncilMember { CouncilActionCouncilMemberId = 5, CouncilMemberId = 6, CouncilActionId = 1, CouncilMembersVote = "Yes" },
        new CouncilActionCouncilMember { CouncilActionCouncilMemberId = 6, CouncilMemberId = 2, CouncilActionId = 1, CouncilMembersVote = "Yes" },
        new CouncilActionCouncilMember { CouncilActionCouncilMemberId = 7, CouncilMemberId = 7, CouncilActionId = 1, CouncilMembersVote = "Yes" }
      );
    }
  }
}