using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

using SandwichBucket.Models;

namespace SandwichBucket
{
  public class SandwichBucketContext : DbContext
  {
    public DbSet<Sandwich> Sandwiches { get; set; }
    public DbSet<Ingredient> Ingredients { get; set; }
    public DbSet<Tag> Tags { get; set; }
    public DbSet<SandwichIngredient> SandwichesIngredients { get; set; }
    public DbSet<SandwichTag> SandwichesTags { get; set; }

    public SandwichBucketContext(DbContextOptions<SandwichBucketContext> options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Sandwich>()
        .HasData(
          SeedSandwichData()
        );
      builder.Entity<Ingredient>()
        .HasData(
          SeedIngredientData()
        );
    }

    private List<Sandwich> SeedSandwichData()
    {
      var sandos = new List<Sandwich>();
      using (StreamReader s = new StreamReader(@"SeedData\Sandwich.json"))
      {
        string j = s.ReadToEnd();
        sandos = JsonSerializer.Deserialize<List<Sandwich>>(j);
      }

      return sandos;
    }
    private List<Ingredient> SeedIngredientData()
    {
      var sandos = new List<Ingredient>();
      using (StreamReader s = new StreamReader(@"SeedData\Ingredient.json"))
      {
        string j = s.ReadToEnd();
        sandos = JsonSerializer.Deserialize<List<Ingredient>>(j);
      }

      return sandos;
    }
  }
}
// ripgrep