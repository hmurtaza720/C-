using System;
using System.Collections.Generic;

namespace EMS_Murtaza.Models;

public partial class SalaryPayment
{
    public int SalaryId { get; set; }

    public int EmployeeId { get; set; }

    public DateOnly PayDate { get; set; }

    public decimal GrossAmount { get; set; }

    public decimal? NetAmount { get; set; }

    public decimal? Commission { get; set; }

    public string? Notes { get; set; }

    public virtual Employee Employee { get; set; } = null!;
}
