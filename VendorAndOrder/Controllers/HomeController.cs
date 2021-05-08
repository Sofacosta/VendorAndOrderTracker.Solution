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
      List<Vendor> allVendors = Vendor.GetAll();
      return View(allVendors);
    }

     [HttpGet("/vendors/new")]
     public ActionResult CreateForm()
     {
       return View();
     }

    [HttpPost("/vendors")]
    public ActionResult Create(string description)
    {
      Vendor myVendor = new Vendor(description);
      return RedirectToAction("Index");
    }
  }
}