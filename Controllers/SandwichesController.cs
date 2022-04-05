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
  public class SandwichesController : Controller
  {
    private readonly SandwichBucketContext _db;

    public SandwichesController(SandwichBucketContext db)
    {
        _db = db;
    }

    // Index
    public ActionResult Index()
    {
      List<Sandwich> Sandwiches = _db.Sandwiches.ToList();
      return View(Sandwiches);
    }

    // GET Create
    public ActionResult Create()
    {
      var model = new CreateViewModel() {
        Ingredients = _db.Ingredients.ToList(),
        Tags = _db.Tags.ToList()
      };

      return View(model);
    }

    // POST Create
    [HttpPost]
    public ActionResult Create(Sandwich sandwich, int[] TagId, int[] IngredientId)
    {
      _db.Sandwiches.Add(sandwich);
      _db.SaveChanges();

      foreach (int t in TagId)
      {
        _db.SandwichesTags.Add(new SandwichTag() {
          TagId = t,
          SandwichId = sandwich.SandwichId
        });
      }

      foreach (int i in IngredientId)
      {
        _db.SandwichesIngredients.Add(new SandwichIngredient() {
          IngredientId = i,
          SandwichId = sandwich.SandwichId
        });
      }
      _db.SaveChanges();

      return RedirectToAction("Index");
    }

    // GET Details
    public ActionResult Details(int id)
    {
      var model = _db.Sandwiches.FirstOrDefault(s => s.SandwichId == id);
      return View(model);
    }

    // GET Edit
    public ActionResult Edit(int id)
    {
      var model = new SandwichEditViewModel() {
        Sandwich = _db.Sandwiches.FirstOrDefault(s => s.SandwichId == id),
        Ingredients = _db.Ingredients.ToList(),
        Tags = _db.Tags.ToList()
      };

      return View(model);
    }

    // POST Edit
    [HttpPost]
    public ActionResult Edit(Sandwich sandwich, int[] TagId, int[] IngredientId)
    {
      _db.SandwichesTags
          .Where(s => s.SandwichId == sandwich.SandwichId && !TagId.Contains(s.TagId))
          .ToList()
          .ForEach(r => _db.SandwichesTags.Remove(r));
      _db.SandwichesIngredients
          .Where(s => s.SandwichId == sandwich.SandwichId && !IngredientId.Contains(s.IngredientId))
          .ToList()
          .ForEach(r => _db.SandwichesIngredients.Remove(r));

      foreach (int t in TagId)
      {
        if (_db.SandwichesTags.Any(st => st.SandwichId == sandwich.SandwichId && st.TagId == t))
          continue;

        _db.SandwichesTags.Add(new SandwichTag() {
          SandwichId = sandwich.SandwichId,
          TagId = t
        });
      }

      foreach (int i in IngredientId)
      {
        if (_db.SandwichesIngredients.Any(si => si.SandwichId == sandwich.SandwichId && si.SandwichId == i))
          continue;

        _db.SandwichesIngredients.Add(new SandwichIngredient() {
          SandwichId = sandwich.SandwichId,
          IngredientId = i
        });
      }

      _db.Entry(sandwich).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    // GET Delete
    public ActionResult Delete(int id)
    {
      var model = _db.Sandwiches.FirstOrDefault(s => s.SandwichId == id);
      return View(model);
    }

    // POST DELETE
    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var sandwich = _db.Sandwiches.FirstOrDefault(s => s.SandwichId == id);
      _db.Sandwiches.Remove(sandwich);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}
