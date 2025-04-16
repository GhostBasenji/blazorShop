using System.Collections.Generic;

namespace Shop.Data.Models;

public class Product
{
    public int ProductID { get; set; }
    public string NameProduct { get; set; } = null!;
    public decimal Price { get; set; }

    public int CategoryID { get; set; }
    public Category Category { get; set; } = null!;

    public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
}
