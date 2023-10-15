using System;
using System.Collections.Generic;

namespace Parcial0220200043.API.Models;

public partial class Country
{
    public int Id { get; set; }

    public string? Description { get; set; }

    public int? Code { get; set; }

    public string? Currency { get; set; }
}
