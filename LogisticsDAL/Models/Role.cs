using System.ComponentModel.DataAnnotations;

namespace LogisticsDAL.Models;

public partial class Role
{
    public int RoleId { get; set; }

    public string? RoleName { get; set; }

    [DataType(DataType.Date)]
    public DateTime? CreatedDate { get; set; }

    [DataType(DataType.Date)]
    public DateTime? ModifiedDate { get; set; }

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
