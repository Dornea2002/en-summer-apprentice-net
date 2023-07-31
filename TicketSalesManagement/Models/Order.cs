using System;
using System.Collections.Generic;

namespace TicketSalesManagement.Models;

public partial class Order
{
    public int Orderid { get; set; }

    public int? NumberOfTickets { get; set; }

    public DateTime? OrderedAt { get; set; }

    public double? TotalPrice { get; set; }

    public int? TicketCategoryid { get; set; }

    public int? Userid { get; set; }

    public virtual TicketCategory? TicketCategory { get; set; }

    public virtual User? User { get; set; }
}
