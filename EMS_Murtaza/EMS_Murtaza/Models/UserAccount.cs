using System;
using System.Collections.Generic;

namespace EMS_Murtaza.Models;

public partial class UserAccount
{
    public int UserId { get; set; }

    public int EmployeeId { get; set; }

    public string Username { get; set; } = null!;

    public string PasswordHash { get; set; } = null!;

    public bool IsLocked { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual Employee Employee { get; set; } = null!;

    public virtual ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();
}
