using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace CityHallTracker.Models
{
  public class CityHallTrackerContextFactory : IDesignTimeDbContextFactory<CityHallTrackerContext>
  {

    CityHallTrackerContext IDesignTimeDbContextFactory<CityHallTrackerContext>.CreateDbContext(string[] args)
    {
      IConfigurationRoot configuration = new ConfigurationBuilder()
          .SetBasePath(Directory.GetCurrentDirectory())
          .AddJsonFile("appsettings.json")
          .Build();

      var builder = new DbContextOptionsBuilder<CityHallTrackerContext>();

      builder.UseMySql(configuration["ConnectionStrings:DefaultConnection"], ServerVersion.AutoDetect(configuration["ConnectionStrings:DefaultConnection"]));

      return new CityHallTrackerContext(builder.Options);
    }
  }
}