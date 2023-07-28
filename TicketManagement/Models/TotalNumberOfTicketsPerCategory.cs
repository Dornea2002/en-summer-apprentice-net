using System;
using System.Collections.Generic;

namespace TicketManagement.Models;

public partial class TotalNumberOfTicketsPerCategory
{
    public int TicketCategoryId { get; set; }

    public int? TicketsSold { get; set; }

    public decimal? TotalSold { get; set; }
}
