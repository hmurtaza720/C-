using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EMS_API_Murtaza.Models;

[Table("Employees", Schema = "m")]
public partial class Employee
{
    [Key]
    public int EmployeeId { get; set; }

    [StringLength(20)]
    public string EmployeeNumber { get; set; } = null!;

    [StringLength(100)]
    public string FirstName { get; set; } = null!;

    [StringLength(100)]
    public string? LastName { get; set; }

    [StringLength(150)]
    public string? Email { get; set; }

    [StringLength(30)]
    public string? Phone { get; set; }

    public DateOnly? DateOfBirth { get; set; }

    public DateOnly HireDate { get; set; }

    public int? DepartmentId { get; set; }

    public int? ManagerId { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? BaseSalary { get; set; }

    public bool IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    [InverseProperty("Employee")]
    public virtual ICollection<Attendance> Attendances { get; set; } = new List<Attendance>();

    [ForeignKey("DepartmentId")]
    [InverseProperty("Employees")]
    public virtual Department? Department { get; set; }

    [InverseProperty("Manager")]
    public virtual ICollection<Employee> InverseManager { get; set; } = new List<Employee>();

    [ForeignKey("ManagerId")]
    [InverseProperty("InverseManager")]
    public virtual Employee? Manager { get; set; }

    [InverseProperty("Employee")]
    public virtual ICollection<SalaryPayment> SalaryPayments { get; set; } = new List<SalaryPayment>();

    [InverseProperty("Employee")]
    public virtual UserAccount? UserAccount { get; set; }
}
