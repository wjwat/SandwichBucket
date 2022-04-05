using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using SandwichBucket.Models;
using SandwichBucket.ViewModels;

namespace SandwichBucket.Controllers
{
  public class IngredientsController : Controller
  {
    private readonly SandwichBucketContext _db;

    public IngredientsController(SandwichBucketContext db)
    {
        _db = db;
    }

    // Index
    public ActionResult Index()
    {
      List<Ingredient> Ingredients = _db.Ingredients.ToList();
      return View(Ingredients);
    }

    // GET Create
    public ActionResult Create()
    {
      var model = new CreateViewModel() {
        Sandwiches = _db.Sandwiches.ToList(),
        Tags = _db.Tags.ToList()
      };

      return View(model);
    }

    // POST Create
    [HttpPost]
    public ActionResult Create(Ingredient ingredient, int[] TagId, int[] SandwichId)
    {
      _db.Ingredients.Add(ingredient);
      _db.SaveChanges();

      foreach (int t in TagId)
      {
        _db.IngredientsTags.Add(new IngredientTag() {
          IngredientId = ingredient.IngredientId,
          TagId = t
        });
      }

      foreach (int s in SandwichId)
      {
        _db.SandwichesIngredients.Add(new SandwichIngredient() {
          IngredientId = ingredient.IngredientId,
          SandwichId = s
        });
      }
      _db.SaveChanges();

      return RedirectToAction("Index");
    }

    // GET Details
    public ActionResult Details(int id)
    {
      var model = _db.Ingredients.FirstOrDefault(i => i.IngredientId == id);
      return View(model);
    }

    // GET Edit
    public ActionResult Edit(int id)
    {
      var model = new IngredientEditViewModel() {
        Ingredient = _db.Ingredients.FirstOrDefault(i => i.IngredientId == id),
        Sandwiches = _db.Sandwiches.ToList(),
        Tags = _db.Tags.ToList()
      };
      return View(model);
    }

    // POST Edit
    [HttpPost]
    public ActionResult Edit(Ingredient ingredient, int[] TagId, int[] SandwichId)
    {
      _db.IngredientsTags
          .Where(i => i.IngredientId == ingredient.IngredientId && !TagId.Contains(i.TagId))
          .ToList()
          .ForEach(r => _db.IngredientsTags.Remove(r));
      _db.SandwichesIngredients
          .Where(i => i.IngredientId == ingredient.IngredientId && !SandwichId.Contains(i.SandwichId))
          .ToList()
          .ForEach(r => _db.SandwichesIngredients.Remove(r));

      foreach (int t in TagId)
      {
        if (_db.IngredientsTags.Any(it => it.IngredientId == ingredient.IngredientId && it.TagId == t))
          continue;

        _db.IngredientsTags.Add(new IngredientTag() {
          IngredientId = ingredient.IngredientId,
          TagId = t
        });
      }

      foreach (int s in SandwichId)
      {
        if (_db.SandwichesIngredients.Any(si => si.IngredientId == ingredient.IngredientId && si.SandwichId == s))
          continue;

        _db.SandwichesIngredients.Add(new SandwichIngredient() {
          IngredientId = ingredient.IngredientId,
          SandwichId = s
        });
      }

      _db.Entry(ingredient).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    // GET Delete
    public ActionResult Delete(int id)
    {
      var model = _db.Ingredients.FirstOrDefault(i => i.IngredientId == id);
      return View(model);
    }

    // POST DELETE
    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var ingredient = _db.Ingredients.FirstOrDefault(i => i.IngredientId == id);
      _db.Ingredients.Remove(ingredient);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}
