using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EMS_API_Murtaza.Models;

[Table("Departments", Schema = "m")]
public partial class Department
{
    [Key]
    public int DepartmentId { get; set; }

    [StringLength(100)]
    public string DepartmentName { get; set; } = null!;

    [StringLength(250)]
    public string? Description { get; set; }

    [InverseProperty("Department")]
    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
