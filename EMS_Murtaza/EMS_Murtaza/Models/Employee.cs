using System;
using System.Collections.Generic;

namespace EMS_Murtaza.Models;

public partial class Employee
{
    public int EmployeeId { get; set; }

    public string EmployeeNumber { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string? LastName { get; set; }

    public string? Email { get; set; }

    public string? Phone { get; set; }

    public DateOnly? DateOfBirth { get; set; }

    public DateOnly HireDate { get; set; }

    public int? DepartmentId { get; set; }

    public int? ManagerId { get; set; }

    public decimal? BaseSalary { get; set; }

    public bool IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual ICollection<Attendance> Attendances { get; set; } = new List<Attendance>();

    public virtual Department? Department { get; set; }

    public virtual ICollection<Employee> InverseManager { get; set; } = new List<Employee>();

    public virtual Employee? Manager { get; set; }

    public virtual ICollection<SalaryPayment> SalaryPayments { get; set; } = new List<SalaryPayment>();

    public virtual UserAccount? UserAccount { get; set; }
}
