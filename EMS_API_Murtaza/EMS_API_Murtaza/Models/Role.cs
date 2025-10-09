using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EMS_API_Murtaza.Models;

[Table("Roles", Schema = "m")]
public partial class Role
{
    [Key]
    public int RoleId { get; set; }

    [StringLength(100)]
    public string RoleName { get; set; } = null!;

    [StringLength(250)]
    public string? Description { get; set; }

    [InverseProperty("Role")]
    public virtual ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();
}
