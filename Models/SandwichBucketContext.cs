using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System;
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
    public DbSet<IngredientTag> IngredientsTags { get; set; }

    public SandwichBucketContext(DbContextOptions<SandwichBucketContext> options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Sandwich>().HasData(SeedData<Sandwich>());
      builder.Entity<Ingredient>().HasData(SeedData<Ingredient>());
      builder.Entity<Tag>().HasData(SeedData<Tag>());
      builder.Entity<SandwichIngredient>().HasData(SeedData<SandwichIngredient>());
    }

    private List<T> SeedData<T>()
    {
      var name = typeof(T).Name;
      List<T> rows = new List<T>();

      using (StreamReader s = new StreamReader(@$"SeedData/{name}.json"))
      {
        string j = s.ReadToEnd();
        rows = JsonSerializer.Deserialize<List<T>>(j);
      }

      return rows;
    }
  }
}
