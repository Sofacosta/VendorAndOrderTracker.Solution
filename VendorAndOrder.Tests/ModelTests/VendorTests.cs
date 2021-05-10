using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendorAndOrder.Models;
using System;

namespace VendorAndOrder.Tests
{
  [TestClass]
  public class VendorTests
  {

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("test");
      Assert.AreEqual(typeof(Vendor),newVendor.GetType());
    }
  }

  // [TestMethod]
  //   public void GetDescription_ReturnsDescription_String()
  //   {
  //     //Arrange
  //     string description = "Sofia's bakery.";

  //     //Act
  //     Vendor newVendor = new (description);
  //     string result = newVendor.Description;

  //     //Assert
  //     Assert.AreEqual(description, result);
  //   }
}
