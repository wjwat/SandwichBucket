using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace SandwichBucket.Models
{
  public class SandwichBucketContextFactory : IDesignTimeDbContextFactory<SandwichBucketContext>
  {

    SandwichBucketContext IDesignTimeDbContextFactory<SandwichBucketContext>.CreateDbContext(string[] args)
    {
      IConfigurationRoot configuration = new ConfigurationBuilder()
          .SetBasePath(Directory.GetCurrentDirectory())
          .AddJsonFile("appsettings.json")
          .Build();

      var builder = new DbContextOptionsBuilder<SandwichBucketContext>();

      builder.UseMySql(configuration["ConnectionStrings:DefaultConnection"], ServerVersion.AutoDetect(configuration["ConnectionStrings:DefaultConnection"]));

      return new SandwichBucketContext(builder.Options);
    }
  }
}
