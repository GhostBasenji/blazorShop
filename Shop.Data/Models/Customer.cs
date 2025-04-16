using System.Collections.Generic;

namespace Shop.Data.Models;

public class Customer
{
    public int CustomerID { get; set; }
    public string FirstName { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Phone { get; set; } = null!;
    public string CustomerAddress { get; set; } = null!;

    public ICollection<Order> Orders { get; set; } = new List<Order>();
}
