using System;
using System.Collections.Generic;

namespace LogisticsDAL.Models;

public partial class Flight
{
    public int FlightId { get; set; }

    public string FlightNumber { get; set; } = null!;

    public string AirlineCode { get; set; } = null!;

    public string AirlineName { get; set; } = null!;

    public int DepartureAirportId { get; set; }

    public int ArrivalAirportId { get; set; }

    public DateTime DepartureTime { get; set; }

    public DateTime ArrivalTime { get; set; }

    public string Status { get; set; } = null!;

    public decimal CargoCapacity { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual Airport ArrivalAirport { get; set; } = null!;

    public virtual Airport DepartureAirport { get; set; } = null!;

    public virtual ICollection<Shipment> Shipments { get; set; } = new List<Shipment>();
}
