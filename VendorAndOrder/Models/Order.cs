using System.Collections.Generic;

namespace VendorAndOrder.Models
{
  public class Order
  {
    private static List<Order> _instances = new List<Order> {};
    public int Id { get; }
    public string Title { get;set;}
    public string Description { get; set;}
    public int Price { get; set;}

    public Order(string title, string description, int price)
    {

      Title = title;
      Description = description;
      Price = price;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static List<Order> GetAll()
    {
      return _instances;
    }
    public static Order Find(int searchId)
    {
      return _instances[searchId-1];
    }
    
  }
}