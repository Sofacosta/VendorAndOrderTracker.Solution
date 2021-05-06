using Microsoft.AspNetCore.Mvc;
using VendorAndOrder.Models;

namespace VendorAndOrder.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Index()
    {
      Vendor starterVendor = new Vendor("Please click below to the vendors page");
      return View(starterVendor);
    }
  }
}