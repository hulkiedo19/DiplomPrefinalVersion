using System;
using System.Collections.Generic;

namespace WpfApp3.Models;

public partial class Order
{
    public int Id { get; set; }

    public DateTime DepartureDate { get; set; }

    public DateTime StartPreparationDate { get; set; }

    public int? KitId { get; set; }

    public int QuantityKit { get; set; }

    public virtual Kit? Kit { get; set; }
}
