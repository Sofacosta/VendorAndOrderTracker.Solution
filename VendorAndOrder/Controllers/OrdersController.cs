using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using VendorAndOrder.Models;

namespace VendorAndOrder.Controllers
{
  public class OrdersController : Controller
  {
   
    [HttpGet("/vendors/{vendorId}/orders/new")]
    public ActionResult New(int vendorId)
    {
      Vendor vendor = Vendor.Find(vendorId);
     return View(vendor);
    }


  [HttpGet("/vendors/{vendorId}/orders/{orderId}")]
  public ActionResult Show(int vendorId, int orderId)
  {
    
    Order Order = Order.Find(orderId);
    Vendor vendor = Vendor.Find(vendorId);
    Dictionary<string, object> model = new Dictionary<string, object>();
    model.Add("order", Order);
    model.Add("vendor", vendor);
    return View(model);
   }
  }
}