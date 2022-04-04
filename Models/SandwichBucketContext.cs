using Microsoft.EntityFrameworkCore;

using SandwichBucket.Models;

namespace SandwichBucket
{
  public class SandwichBucketContext : DbContext
  {
    public DbSet<Sandwich> Sandwiches { get; set; }
    public DbSet<Ingredient> Ingredients { get; set; }
    public DbSet<Tag> Tags { get; set; }
    public DbSet<SandwichIngredient> SandwichesIngredients { get; set; }
    public DbSet<SandwichTag> SandwitchesTags { get; set; }

    public SandwichBucketContext(DbContextOptions<SandwichBucketContext> options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}
