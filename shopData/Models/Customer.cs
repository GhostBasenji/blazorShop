﻿using System;
using System.Collections.Generic;

namespace shopData.Models;

public partial class Customer
{
    public int CustomerId { get; set; }

    public string FirstName { get; set; } = null!;

    public string? Email { get; set; }

    public string? Phone { get; set; }

    public string? CustomerAddress { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
