using System;
using System.Collections.Generic;

namespace EMS_Murtaza.Models;

public partial class AuditLog
{
    public int LogId { get; set; }

    public string Action { get; set; } = null!;

    public string? TableName { get; set; }

    public string? RecordId { get; set; }

    public int? UserId { get; set; }

    public DateTime CreatedAt { get; set; }
}
