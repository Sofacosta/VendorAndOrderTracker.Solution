using Microsoft.AspNetCore.Mvc;
using VendorAndOrder.Models;

namespace VendorAndOrder.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Index()
    {
      Item starterItem = new Item("Please click to the vendors page");
      return View(starterItem);
    }


  }
}