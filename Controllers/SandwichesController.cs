using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
      ViewBag.Ingredients = _db.Ingredients.ToList();
      ViewBag.Tags = _db.Tags.ToList();

      return View();
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
      var model = _db.Sandwiches.FirstOrDefault(s => s.SandwichId == id);
      ViewBag.Ingredients = _db.Ingredients.ToList();
      ViewBag.Tags = _db.Tags.ToList();
      ViewBag.SandwichesIngredients = _db.SandwichesIngredients
          .Where(s => s.SandwichId == id)
          .Select(i => i.IngredientId)
          .ToList();
      ViewBag.SandwichesTags = _db.SandwichesTags
          .Where(s => s.SandwichId == id)
          .Select(t => t.TagId)
          .ToList();
      // var model = new SandwichEditViewModel() {
      //   Sandwich = _db.Sandwiches.FirstOrDefault(s => s.SandwichId == id),
      //   Ingredients = _db.Ingredients.ToList(),
      //   Tags = _db.Tags.ToList()
      // };

      return View(model);
    }

    // Before Edit
    // 1 => 0, 2, 4
    // After Edit
    // 1 => 1, 2, 4, 6 (Removed 0, and Added 1, 6)
    // 2nd Edit
    // 1 => 0, 2, 4 (Added 0, Removed 1, 6)

    // SandwichId=2
    // &Name=Banh+Mi
    // &Description=Hell+yes
    // &Alignment=LawfulEvil
    // &IngredientId=1
    // &IngredientId=2
    // &IngredientId=4
    // &IngredientId=6
    // &IngredientId=17
    // &IngredientId=28
    // &IngredientId=33
    // &IngredientId=43
    // &IngredientId=54
    // &IngredientId=65
    // &IngredientId=118
    // &IngredientId=119&

    // POST Edit
    [HttpPost]
    public ActionResult Edit(Sandwich sandwich, int[] TagId, int[] IngredientId)
    {
      // If this relationship existed before the Edit and doesn't exist at this point
      // I need to remove it
      _db.SandwichesTags
          .Where(s => s.SandwichId == sandwich.SandwichId && !TagId.Contains(s.TagId))
          .ToList()
          .ForEach(r => _db.SandwichesTags.Remove(r));
      _db.SandwichesIngredients
          .Where(s => s.SandwichId == sandwich.SandwichId && !IngredientId.Contains(s.IngredientId))
          .ToList()
          .ForEach(r => _db.SandwichesIngredients.Remove(r));

      // If this relationship doesn't already exist at this point, I need to create it
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

    public async Task<ActionResult<Object>> Random()
    {
      var sandwichCount = await _db.Sandwiches.CountAsync();
      var sandwich = await _db.Sandwiches
              .Skip(new Random().Next(sandwichCount))
              .FirstOrDefaultAsync();
      
      return Json(new {
        Name = sandwich.Name,
        Description = sandwich.Description,
        Alignment = sandwich.Alignment,
        SandwichId = sandwich.SandwichId
      });
    }
  }
}
