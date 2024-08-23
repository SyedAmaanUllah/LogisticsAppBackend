using System.ComponentModel.DataAnnotations;

public class RoleDTO
{
    [Required]
    public int RoleId { get; set; }

    [Required]
    [StringLength(50)]
    public string RoleName { get; set; }

    [DataType(DataType.Date)]
    public DateTime CreatedDate { get; set; } = DateTime.Now;

    [DataType(DataType.Date)]
    public DateTime? ModifiedDate { get; set; }
}
