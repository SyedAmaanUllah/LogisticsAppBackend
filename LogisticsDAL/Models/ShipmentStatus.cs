using System;
using System.Collections.Generic;

namespace LogisticsDAL.Models;

public partial class ShipmentStatus
{
    public int StatusId { get; set; }

    public string StatusName { get; set; } = null!;

    public string? Description { get; set; }

    public virtual ICollection<Shipment> Shipments { get; set; } = new List<Shipment>();
}
