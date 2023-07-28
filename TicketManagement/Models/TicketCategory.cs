﻿using System;
using System.Collections.Generic;

namespace TicketManagement.Models;

public partial class TicketCategory
{
    public int TicketCategoryid { get; set; }

    public string? Description { get; set; }

    public double? Price { get; set; }

    public int? Eventid { get; set; }

    public virtual Event? Event { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
