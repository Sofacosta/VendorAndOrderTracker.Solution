using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorAndOrder.Models;
using System.Collections.Generic;
using System;

namespace VendorAndOrder.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("test order");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
  public void GetName_ReturnsName_String()
  {
    //Arrange
    string name = "Test Order";
    Order newOrder = new Order(name);

    //Act
    string result = newOrder.Name;

    //Assert
    Assert.AreEqual(name, result);
  }

  [TestMethod]
  public void GetId_ReturnsOrderId_Int()
  {
    //Arrange
    string name = "Test Order";
    Order newOrder = new Order(name);

    //Act
    int result = newOrder.Id;

    //Assert
    Assert.AreEqual(1, result);
  }

  [TestMethod]
  public void GetAll_ReturnsAllOrderObjects_OrderList()
  {
    //Arrange
    string name01 = "Work";
    string name02 = "School";
    Order newOrder1 = new Order(name01);
    Order newOrder2 = new Order(name02);
    List<Order> newList = new List<Order> { newOrder1, newOrder2 };

    //Act
    List<Order> result = Order.GetAll();

    //Assert
    CollectionAssert.AreEqual(newList, result);
  }

  [TestMethod]
  public void Find_ReturnsOrder_Order()
  {
    //Arrange
    string name01 = "Work";
    string name02 = "School";
    Order newOrder1 = new Order(name01);
    Order newOrder2 = new Order(name02);

    //Act
    Order result = Order.Find(2);

    //Assert
    Assert.AreEqual(newOrder2, result);
  }

  [TestMethod]
  public void AddVendor_AssociatesVendorWithOrder_VendorList()
  {
    //Arrange
    string description = "Walk the dog.";
    Vendor newVendor = new Vendor(description);
    List<Vendor> newList = new List<Vendor> { newVendor };
    string name = "Work";
    Order newOrder = new Order(name);
    newOrder.AddVendor(newVendor);

    //Act
    List<Vendor> result = newOrder.Vendors;

    //Assert
    CollectionAssert.AreEqual(newList, result);
  }

  }
}