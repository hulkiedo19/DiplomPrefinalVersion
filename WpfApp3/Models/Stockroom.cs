using System;
using System.Collections.Generic;

namespace WpfApp3.Models;

public partial class Stockroom
{
    public int Id { get; set; }

    public TimeSpan OpeningTime { get; set; }

    public TimeSpan ClosingTime { get; set; }

    public int Capacity { get; set; }

    public int FreeSpace { get; set; }

    public virtual ICollection<Kit> Kits { get; } = new List<Kit>();
}
