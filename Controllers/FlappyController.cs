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
  public class FlappyController : Controller
  {
    private readonly ILogger<FlappyController> _logger;
    private readonly SandwichBucketContext _db;

    public FlappyController(ILogger<FlappyController> logger, SandwichBucketContext db)
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
