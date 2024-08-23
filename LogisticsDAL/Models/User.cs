using System;
using System.Collections.Generic;

namespace LogisticsDAL.Models;

public partial class User
{
    public int UserId { get; set; }

    public string UserName { get; set; } = null!;

    public string PasswordHash { get; set; } = null!;

    public string Email { get; set; } = null!;

    public int RoleId { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsActivate { get; set; }

    public virtual Role Role { get; set; } = null!;
}
