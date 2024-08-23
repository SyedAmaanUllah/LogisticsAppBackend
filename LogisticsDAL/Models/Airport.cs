namespace LogisticsDAL.Models;

public partial class Airport
{
    public int AirportId { get; set; }

    public string AirportCode { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? Location { get; set; }

    public string? Country { get; set; }

    public string? Facilities { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual ICollection<Flight> FlightArrivalAirports { get; set; } = new List<Flight>();

    public virtual ICollection<Flight> FlightDepartureAirports { get; set; } = new List<Flight>();

    public virtual ICollection<Shipment> ShipmentDestinationAirports { get; set; } = new List<Shipment>();

    public virtual ICollection<Shipment> ShipmentOriginAirports { get; set; } = new List<Shipment>();
}
