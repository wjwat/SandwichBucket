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
  public class ScalesController : Controller
  {
    private readonly ILogger<ScalesController> _logger;
    private readonly SandwichBucketContext _db;

    public ScalesController(ILogger<ScalesController> logger, SandwichBucketContext db)
    {
      _logger = logger;
      _db = db;
    }

    public ActionResult Index()
    {
      return View();
    }
  }
}