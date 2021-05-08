using Microsoft.AspNetCore.Mvc;
using VendorAndOrder.Models;
using System.Collections.Generic;

namespace VendorAndOrder.Controllers
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