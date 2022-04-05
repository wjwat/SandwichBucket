using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

using SandwichBucket.Models;
using SandwichBucket.ViewModels;

namespace SandwichBucket.Controllers
{
  public class SandwichBattleController : Controller
  {
    private readonly ILogger<SandwichBattleController> _logger;

    private readonly SandwichBucketContext _db;

    public SandwichBattleController(ILogger<SandwichBattleController> logger, SandwichBucketContext db)
    {
      _logger = logger;
      _db = db;
    }

   public async Task<IActionResult> Index()
    {
      var sandwichCount = await _db.Sandwiches.CountAsync();
      var tagCount = await _db.Tags.CountAsync();
      var ingredientCount = await _db.Ingredients.CountAsync();

      // Count of random items to display on our front page
      var randomCount = new Random().Next(3, 10);
      var randomIngredients = new List<Ingredient>();

      for (int x = 0; x < randomCount; x++)
      {
        randomIngredients.Add(_db.Ingredients
            .Skip(new Random().Next(ingredientCount))
            .FirstOrDefault());
      }

      var model = new HomeViewModel()
      {
        Sandwich = await _db.Sandwiches
            .Skip(new Random().Next(sandwichCount))
            .FirstOrDefaultAsync(),
        Ingredient = await _db.Ingredients
            .Skip(new Random().Next(ingredientCount))
            .FirstOrDefaultAsync(),
        Tag = await _db.Tags
            .Skip(new Random().Next(tagCount))
            .FirstOrDefaultAsync(),
        RandomSandwich = randomIngredients
      };

      // Pull out random items, pass them into the view
      return View(model);
    }
  }
}
