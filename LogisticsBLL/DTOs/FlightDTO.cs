using System;
using System.ComponentModel.DataAnnotations;

namespace LogisticsBLL.DTOs
{
    public class FlightDTO
    {
        [Required]
        public int FlightId { get; set; }

        [Required]
        [StringLength(50)]
        public string FlightNumber { get; set; }

        [Required]
        public int AirlineId { get; set; }

        [Required]
        public int DepartureAirportId { get; set; }

        [Required]
        public int ArrivalAirportId { get; set; }

        [Required]
        public DateTime DepartureTime { get; set; }

        [Required]
        public DateTime ArrivalTime { get; set; }

        [DataType(DataType.Date)]
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        [DataType(DataType.Date)]
        public DateTime? ModifiedDate { get; set; }
    }

}
