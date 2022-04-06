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
  public class FlappyBirdWebBuildController : Controller
  {
    private readonly ILogger<FlappyBirdWebBuildController> _logger;
    private readonly SandwichBucketContext _db;

    public FlappyBirdWebBuildController(ILogger<FlappyBirdWebBuildController> logger, SandwichBucketContext db)
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
