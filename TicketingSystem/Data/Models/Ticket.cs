using System;
using System.Collections.Generic;

namespace Data.Models;

public partial class Ticket
{
    public int Id { get; set; }

    public string? Origin { get; set; }

    public string? Destination { get; set; }

    public DateTime? Departure { get; set; }

    public DateTime? Arrival { get; set; }

    public int? BookedBy { get; set; }

    public string? TravlerName { get; set; }
}
