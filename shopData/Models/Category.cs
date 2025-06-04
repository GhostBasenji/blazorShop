using System;
using System.Collections.Generic;

namespace shopData.Models;

public partial class Category
{
    public int CategoryId { get; set; }

    public string NameCategories { get; set; } = null!;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
