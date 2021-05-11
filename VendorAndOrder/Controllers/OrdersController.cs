using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using VendorAndOrder.Models;

namespace VendorAndOrder.Controllers
{
  public class OrdersController : Controller
  {
    [HttpGet("/orders")]
    public ActionResult Index()
    {
      List<Order> allOrders = Order.GetAll();
      return View(allOrders);
    }
   
    [HttpGet("/orders/new")]
    public ActionResult New()
    {
     return View();
    }

  [HttpPost("/orders")]
  public ActionResult Create(string categoryName)
  {
    Order newOrder = new Order (categoryName);
    return RedirectToAction("Index");
  }
  [HttpGet("/orders/{id}")]
  public ActionResult Show(int id)
  {
    Dictionary<string, object> model = new Dictionary<string, object>();
    Order selectedOrder = Order.Find(id);
    List<Vendor> orderItems = selectedOrder.Vendors;
    model.Add("order", selectedOrder);
    model.Add("vendor", orderItems);
    return View(model);
  }


  }
}
