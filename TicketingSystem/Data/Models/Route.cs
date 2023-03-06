using System;
using System.Collections.Generic;

namespace Data.Models;

public partial class Route
{
    public int Id { get; set; }

    public string? Origin { get; set; }

    public string? Destinations { get; set; }
}
