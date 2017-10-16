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
      [HttpPost("/attack")]
      public ActionResult Attack()
      {
        return View(Chess.CompareCoordinates(int.Parse(Request.Form["queen-x"]), int.Parse(Request.Form["queen-y"]), int.Parse(Request.Form["other-x"]), int.Parse(Request.Form["other-y"])));
      }
    }
}
