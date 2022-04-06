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
      List<Tag> Tags = _db.Tags.ToList();
      return View(Tags);
    }

    // GET Create
    public ActionResult Create()
    {
      return View();
    }

    // POST Create
    [HttpPost]
    public ActionResult Create(Tag tag)
    {
      _db.Tags.Add(tag);
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
      var model = _db.Tags.FirstOrDefault(t => t.TagId == id);
      return View(model);
    }

    // POST Edit
    [HttpPost]
    public ActionResult Edit(Tag tag)
    {
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
