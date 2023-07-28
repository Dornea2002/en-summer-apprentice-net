using System;
using System.Collections.Generic;

namespace TicketManagement.Models;

public partial class EventType
{
    public int EventTypeid { get; set; }

    public string? EventTypeName { get; set; }

    public virtual ICollection<Event> Events { get; set; } = new List<Event>();
}
