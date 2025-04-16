using System.Collections.Generic;

namespace Shop.Data.Models;

public class Category
{
    public int CategoryID { get; set; }
    public string NameCategories { get; set; } = null!;

    public ICollection<Product> Products { get; set; } = new List<Product>();
}
