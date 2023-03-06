using System;
using System.Collections.Generic;

namespace Data.Models;

public partial class User
{
    public int UserId { get; set; }

    public string? UserName { get; set; }

    public DateTime? CreationDate { get; set; }

    public DateTime? ExpiryDate { get; set; }
}
