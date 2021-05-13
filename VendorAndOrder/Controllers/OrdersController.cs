using System.Collections.Generic;
// using System;
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
    Dictionary<string, object> model = new Dictionary<string, object>();
    Order selectedOrder = Order.Find(orderId);
    Vendor vendor = Vendor.Find(vendorId);
    //List<Vendor> orderItems = selectedOrder.Vendors;
    model.Add("order", selectedOrder);
    model.Add("vendor", vendor);
    return View(model);
   }
  }
}