using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EMS_API_Murtaza.Models;

[Table("UserAccounts", Schema = "m")]
public partial class UserAccount
{
    [Key]
    public int UserId { get; set; }

    public int EmployeeId { get; set; }

    [StringLength(100)]
    public string Username { get; set; } = null!;

    [StringLength(256)]
    public string PasswordHash { get; set; } = null!;

    public bool IsLocked { get; set; }

    public DateTime CreatedAt { get; set; }

    [ForeignKey("EmployeeId")]
    [InverseProperty("UserAccount")]
    public virtual Employee Employee { get; set; } = null!;

    [InverseProperty("User")]
    public virtual ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();
}
