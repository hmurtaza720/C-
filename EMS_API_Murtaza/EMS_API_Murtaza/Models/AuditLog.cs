using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EMS_API_Murtaza.Models;

[Table("AuditLog", Schema = "m")]
public partial class AuditLog
{
    [Key]
    public int LogId { get; set; }

    [StringLength(100)]
    public string Action { get; set; } = null!;

    [StringLength(100)]
    public string? TableName { get; set; }

    [StringLength(50)]
    public string? RecordId { get; set; }

    public int? UserId { get; set; }

    public DateTime CreatedAt { get; set; }
}
