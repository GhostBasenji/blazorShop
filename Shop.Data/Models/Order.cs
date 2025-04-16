using System;
using System.Collections.Generic;

namespace Shop.Data.Models;

public class Order
{
    public int OrderID { get; set; }

    public int CustomerID { get; set; }
    public Customer Customer { get; set; } = null!;

    public DateTime OrderDate { get; set; }
    public string DeliveryAddress { get; set; } = null!;

    public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
}
