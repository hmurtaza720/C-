using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EMS_API_Murtaza.Models;

public partial class EMSContext : DbContext
{
    public EMSContext()
    {
    }

    public EMSContext(DbContextOptions<EMSContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Attendance> Attendances { get; set; }

    public virtual DbSet<AuditLog> AuditLogs { get; set; }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<SalaryPayment> SalaryPayments { get; set; }

    public virtual DbSet<UserAccount> UserAccounts { get; set; }

    public virtual DbSet<UserRole> UserRoles { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=172.17.40.11;Database=intern_devdb;User Id=intern;Password=intern@123;TrustServerCertificate=True;Trusted_Connection=False;");

    //protected override void OnModelCreating(ModelBuilder modelBuilder)
    //{
    //    modelBuilder.Entity<Attendance>(entity =>
    //    {
    //        entity.HasKey(e => e.AttendanceId)
    //            .HasName("PK__Attendan__8B69261C81DAB6FE")
    //            .HasFillFactor(80);

    //        entity.HasOne(d => d.Employee).WithMany(p => p.Attendances)
    //            .OnDelete(DeleteBehavior.ClientSetNull)
    //            .HasConstraintName("FK_m_Attendance_Employee");
    //    });

    //    modelBuilder.Entity<AuditLog>(entity =>
    //    {
    //        entity.HasKey(e => e.LogId)
    //            .HasName("PK__AuditLog__5E54864867481463")
    //            .HasFillFactor(80);

    //        entity.Property(e => e.CreatedAt).HasDefaultValueSql("(sysutcdatetime())");
    //    });

    //    modelBuilder.Entity<Department>(entity =>
    //    {
    //        entity.HasKey(e => e.DepartmentId)
    //            .HasName("PK__Departme__B2079BED125C0DA9")
    //            .HasFillFactor(80);

    //        entity.HasIndex(e => e.DepartmentName, "UQ__Departme__D949CC3420A1E122")
    //            .IsUnique()
    //            .HasFillFactor(80);
    //    });

    //    modelBuilder.Entity<Employee>(entity =>
    //    {
    //        entity.HasKey(e => e.EmployeeId)
    //            .HasName("PK__Employee__7AD04F11EC372D99")
    //            .HasFillFactor(80);

    //        entity.HasIndex(e => e.EmployeeNumber, "UQ__Employee__8D663598F5612DCF")
    //            .IsUnique()
    //            .HasFillFactor(80);

    //        entity.HasIndex(e => e.Email, "UQ__Employee__A9D10534EB57C964")
    //            .IsUnique()
    //            .HasFillFactor(80);

    //        entity.Property(e => e.CreatedAt).HasDefaultValueSql("(sysutcdatetime())");
    //        entity.Property(e => e.HireDate).HasDefaultValueSql("(CONVERT([date],getdate()))");
    //        entity.Property(e => e.IsActive).HasDefaultValue(true);

    //        entity.HasOne(d => d.Department).WithMany(p => p.Employees).HasConstraintName("FK_m_Employees_Department");

    //        entity.HasOne(d => d.Manager).WithMany(p => p.InverseManager).HasConstraintName("FK_m_Employees_Manager");
    //    });

    //    modelBuilder.Entity<Role>(entity =>
    //    {
    //        entity.HasKey(e => e.RoleId)
    //            .HasName("PK__Roles__8AFACE1A0C4E5A7B")
    //            .HasFillFactor(80);

    //        entity.HasIndex(e => e.RoleName, "UQ__Roles__8A2B616062BE2185")
    //            .IsUnique()
    //            .HasFillFactor(80);
    //    });

    //    modelBuilder.Entity<SalaryPayment>(entity =>
    //    {
    //        entity.HasKey(e => e.SalaryId)
    //            .HasName("PK__SalaryPa__4BE2045717C20AB6")
    //            .HasFillFactor(80);

    //        entity.HasOne(d => d.Employee).WithMany(p => p.SalaryPayments)
    //            .OnDelete(DeleteBehavior.ClientSetNull)
    //            .HasConstraintName("FK_m_SalaryPayments_Employee");
    //    });

    //    modelBuilder.Entity<UserAccount>(entity =>
    //    {
    //        entity.HasKey(e => e.UserId)
    //            .HasName("PK__UserAcco__1788CC4CE4D52132")
    //            .HasFillFactor(80);

    //        entity.HasIndex(e => e.Username, "UQ__UserAcco__536C85E4B26373B0")
    //            .IsUnique()
    //            .HasFillFactor(80);

    //        entity.HasIndex(e => e.EmployeeId, "UQ__UserAcco__7AD04F10FF86E612")
    //            .IsUnique()
    //            .HasFillFactor(80);

    //        entity.Property(e => e.CreatedAt).HasDefaultValueSql("(sysutcdatetime())");

    //        entity.HasOne(d => d.Employee).WithOne(p => p.UserAccount)
    //            .OnDelete(DeleteBehavior.ClientSetNull)
    //            .HasConstraintName("FK_m_UserAccounts_Employee");
    //    });

    //    modelBuilder.Entity<UserRole>(entity =>
    //    {
    //        entity.HasKey(e => e.UserRoleId)
    //            .HasName("PK__UserRole__3D978A357D0D9D22")
    //            .HasFillFactor(80);

    //        entity.HasIndex(e => new { e.UserId, e.RoleId }, "UQ_m_UserRole_User_Role")
    //            .IsUnique()
    //            .HasFillFactor(80);

    //        entity.Property(e => e.AssignedAt).HasDefaultValueSql("(sysutcdatetime())");

    //        entity.HasOne(d => d.Role).WithMany(p => p.UserRoles)
    //            .OnDelete(DeleteBehavior.ClientSetNull)
    //            .HasConstraintName("FK_m_UserRoles_Role");

    //        entity.HasOne(d => d.User).WithMany(p => p.UserRoles)
    //            .OnDelete(DeleteBehavior.ClientSetNull)
    //            .HasConstraintName("FK_m_UserRoles_User");
    //    });

    //    OnModelCreatingPartial(modelBuilder);
    //}

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
