using System.ComponentModel.DataAnnotations;

public class AirportDTO
{
    [Required]
    public int AirportId { get; set; }

    [Required]
    [StringLength(10)]
    public string AirportCode { get; set; } = null!;

    [Required]
    [StringLength(100)]
    public string Name { get; set; } = null!;

    [StringLength(200)]
    public string? Location { get; set; }

    [StringLength(100)]
    public string? Country { get; set; }

    [StringLength(500)]
    public string? Facilities { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }
}
