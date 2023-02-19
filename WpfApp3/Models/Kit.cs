using System;
using System.Collections.Generic;

namespace WpfApp3.Models;

public partial class Kit
{
    public int Id { get; set; }

    public int? ProductTypeId { get; set; }

    public int QuantitySet { get; set; }

    public int? StockroomId { get; set; }

    public int StockroomDeliveryDate { get; set; }

    public virtual ICollection<Order> Orders { get; } = new List<Order>();

    public virtual ProductType? ProductType { get; set; }

    public virtual Stockroom? Stockroom { get; set; }
}
