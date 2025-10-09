using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EMS_API_Murtaza.Models;

[Table("Attendance", Schema = "m")]
public partial class Attendance
{
    [Key]
    public int AttendanceId { get; set; }

    public int EmployeeId { get; set; }

    public DateOnly WorkDate { get; set; }

    public DateTime? CheckIn { get; set; }

    public DateTime? CheckOut { get; set; }

    [StringLength(20)]
    public string? Status { get; set; }

    [ForeignKey("EmployeeId")]
    [InverseProperty("Attendances")]
    public virtual Employee Employee { get; set; } = null!;
}
