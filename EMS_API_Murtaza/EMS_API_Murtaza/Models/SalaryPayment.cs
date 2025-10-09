using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EMS_API_Murtaza.Models;

[Table("SalaryPayments", Schema = "m")]
public partial class SalaryPayment
{
    [Key]
    public int SalaryId { get; set; }

    public int EmployeeId { get; set; }

    public DateOnly PayDate { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal GrossAmount { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? NetAmount { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? Commission { get; set; }

    [StringLength(250)]
    public string? Notes { get; set; }

    [ForeignKey("EmployeeId")]
    [InverseProperty("SalaryPayments")]
    public virtual Employee Employee { get; set; } = null!;
}
