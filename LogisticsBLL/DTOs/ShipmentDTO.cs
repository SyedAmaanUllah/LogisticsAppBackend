using LogisticsDAL.Models;
using System;
using System.ComponentModel.DataAnnotations;

public class ShipmentDTO
{
    [Required]
    public int ShipmentId { get; set; }

    [Required]
    [StringLength(20)]
    public string ShipmentCode { get; set; } = null!;

    [StringLength(500)]
    public string? Description { get; set; }

    [Required]
    public int OriginAirportId { get; set; }

    [Required]
    public int DestinationAirportId { get; set; }

    [Required]
    public int CustomerId { get; set; }

    [Required]
    public int FlightId { get; set; }

    [Required]
    public int StatusId { get; set; }

    [Required]
    public DateTime ShipmentDate { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }
    public string? OriginAirportName { get; set; }
    public string? DestinationAirportName { get; set; }
    public string? CustomerName { get; set; }
    public string? FlightNumber { get; set; }
    public string? StatusName { get; set; }
}
