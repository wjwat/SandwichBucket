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
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly SandwichBucketContext _db;

        public HomeController(ILogger<HomeController> logger, SandwichBucketContext db)
        {
            _logger = logger;
            _db = db;
        }

        // Have a random sandwich, ingredient, and tag shown on the front page
        // as well as a list of random ingredients and challenge a visitor
        // to make a sandwich with it
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
                    .Include(sando => sando.Ingredients) //Trying to include ingredients with the sandwich. 
                    .ThenInclude(join => join.Ingredient)  //Trying to include ingredients with the sandwich. 
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

        // You have none, welcome to the internet
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
