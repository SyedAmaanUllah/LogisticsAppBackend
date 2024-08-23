using System;
using System.Collections.Generic;

namespace LogisticsDAL.Models;

public partial class Shipment
{
    public int ShipmentId { get; set; }

    public string ShipmentCode { get; set; } = null!;

    public string? Description { get; set; }

    public int OriginAirportId { get; set; }

    public int DestinationAirportId { get; set; }

    public int CustomerId { get; set; }

    public int FlightId { get; set; }

    public int StatusId { get; set; }

    public DateTime ShipmentDate { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual Customer Customer { get; set; } = null!;

    public virtual Airport DestinationAirport { get; set; } = null!;

    public virtual Flight Flight { get; set; } = null!;

    public virtual Airport OriginAirport { get; set; } = null!;

    public virtual ShipmentStatus Status { get; set; } = null!;
}
