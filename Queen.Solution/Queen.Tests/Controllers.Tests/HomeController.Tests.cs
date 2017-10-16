using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Queen.Models;

namespace Queen.Controllers
{
    public class HomeController : Controller
    {
      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }
    }
}
