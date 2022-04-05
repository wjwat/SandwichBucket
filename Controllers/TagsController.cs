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
  public class TagsController : Controller
  {
    private readonly SandwichBucketContext _db;

    public TagsController(SandwichBucketContext db)
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
        Ingredients = _db.Ingredients.ToList(),
        Sandwiches = _db.Sandwiches.ToList()
      };

      return View(model);
    }

    // POST Create
    [HttpPost]
    public ActionResult Create(Tag tag, int[] IngredientId, int[] SandwichId)
    {
      _db.Tags.Add(tag);
      _db.SaveChanges();

      foreach (int i in IngredientId)
      {
        _db.IngredientsTags.Add(new IngredientTag() {
          TagId = tag.TagId,
          IngredientId = i
        });
      }

      foreach (int s in SandwichId)
      {
        _db.SandwichesTags.Add(new SandwichTag() {
          TagId = tag.TagId,
          SandwichId = s
        });
      }
      _db.SaveChanges();

      return RedirectToAction("Index");
    }

    // GET Details
    public ActionResult Details(int id)
    {
      var model = _db.Tags.FirstOrDefault(t => t.TagId == id);
      return View(model);
    }

    // GET Edit
    public ActionResult Edit(int id)
    {
      var model = new TagEditViewModel() {
        Ingredients = _db.Ingredients.ToList(),
        Sandwiches = _db.Sandwiches.ToList(),
        Tag = _db.Tags.FirstOrDefault(t => t.TagId == id)
      };
      return View(model);
    }

    // POST Edit
    [HttpPost]
    public ActionResult Edit(Tag tag, int[] IngredientId, int[] SandwichId)
    {
      _db.IngredientsTags
          .Where(t => t.TagId == tag.TagId && !IngredientId.Contains(t.IngredientId))
          .ToList()
          .ForEach(r => _db.IngredientsTags.Remove(r));
      _db.SandwichesTags
          .Where(t => t.TagId == tag.TagId && !SandwichId.Contains(t.SandwichId))
          .ToList()
          .ForEach(r => _db.SandwichesTags.Remove(r));

      foreach (int i in IngredientId)
      {
        if (_db.IngredientsTags.Any(it => it.TagId == tag.TagId && it.IngredientId == i))
          continue;

        _db.IngredientsTags.Add(new IngredientTag() {
          IngredientId = i,
          TagId = tag.TagId
        });
      }

      foreach (int s in SandwichId)
      {
        if (_db.SandwichesTags.Any(st => st.TagId == tag.TagId && st.SandwichId == s))
          continue;

        _db.SandwichesTags.Add(new SandwichTag() {
          TagId = tag.TagId,
          SandwichId = s
        });
      }

      _db.Entry(tag).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    // GET Delete
    public ActionResult Delete(int id)
    {
      var model = _db.Tags.FirstOrDefault(t => t.TagId == id);
      return View(model);
    }

    // POST DELETE
    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var tag = _db.Tags.FirstOrDefault(t => t.TagId == id);
      _db.Tags.Remove(tag);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}
