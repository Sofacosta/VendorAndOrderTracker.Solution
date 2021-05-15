using Microsoft.AspNetCore.Mvc;
using VendorAndOrder.Models;
using System.Collections.Generic;

namespace VendorAndOrder.Controllers
{
  public class VendorsController : Controller
  {
    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> allVendors = Vendor.GetAll();
      return View(allVendors);
    }

     [HttpGet("/vendors/new")]
     public ActionResult New()
     {
       return View();
     }

    [HttpPost("/vendors")]
    public ActionResult Create(string name)
    {
      Vendor myVendor = new Vendor(name);
      return RedirectToAction("Index");
    }

    [HttpGet("/vendors/{id}")]
    public ActionResult Show(int id)
    {
      Dictionary<string,object> model = new Dictionary<string,object>();
      Vendor vendor = Vendor.Find(id);
      List<Order> vendorOrders = vendor.Orders;
      model.Add("vendor", vendor);
      model.Add("orders", vendorOrders);
      return View(model);
    }

    [HttpPost("/vendors/{vendorId}/orders")]
    public ActionResult Create(int vendorId, string orderTitle, string orderDescription, int orderPrice)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor foundVendor = Vendor.Find(vendorId);
      Order newOrder = new Order(orderTitle, orderDescription, orderPrice);
      foundVendor.AddOrder(newOrder);
      List<Order> VendorOrders = foundVendor.Orders;
      model.Add("orders", VendorOrders);
      model.Add("vendor", foundVendor);
      return View("Show", model);
    }



  }
}