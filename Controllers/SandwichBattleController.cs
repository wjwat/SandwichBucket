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
    public ActionResult Index(){
      return View();
    }
  }
}
