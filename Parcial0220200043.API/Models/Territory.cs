using System;
using System.Collections.Generic;

namespace Parcial0220200043.API.Models;

public partial class Territory
{
    public int Id { get; set; }

    public string? Description { get; set; }

    public string? Area { get; set; }

    public string? Population { get; set; }
}
