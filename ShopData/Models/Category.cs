using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ShopData.Models;

public partial class Category
{
    public Category()
    {
        Products = new HashSet<Product>();
    }
    [Key]
    [Column("CategoryID")]
    public int CategoryId { get; set; }

    [StringLength(30)]
    public string NameCategories { get; set; }

    [InverseProperty("Category")]
    public virtual ICollection<Product> Products { get; set; }
}
