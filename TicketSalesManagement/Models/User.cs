using System;
using System.Collections.Generic;

namespace TicketSalesManagement.Models;

public partial class User
{
    public int Userid { get; set; }

    public string? Email { get; set; }

    public string? UserName { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
