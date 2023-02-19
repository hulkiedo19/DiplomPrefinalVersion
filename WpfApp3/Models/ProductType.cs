using System;
using System.Collections.Generic;

namespace WpfApp3.Models;

public partial class ProductType
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int Width { get; set; }

    public int Length { get; set; }

    public int Thickness { get; set; }

    public int Weight { get; set; }

    public virtual ICollection<Kit> Kits { get; } = new List<Kit>();
}
