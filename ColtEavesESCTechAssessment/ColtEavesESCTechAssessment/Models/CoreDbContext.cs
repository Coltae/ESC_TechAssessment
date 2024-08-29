using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ColtEavesESCTechAssessment.Models;

public partial class CoreDbContext : DbContext
{
    public CoreDbContext()
    {
    }

    public CoreDbContext(DbContextOptions<CoreDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Country> Countries { get; set; }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<Dependent> Dependents { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Job> Jobs { get; set; }

    public virtual DbSet<Location> Locations { get; set; }

    public virtual DbSet<Region> Regions { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.;Database=master;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Country>(entity =>
        {
            entity.HasKey(e => e.CountryId).HasName("PK__countrie__7E8CD055BBD326F8");

            entity.Property(e => e.CountryId).IsFixedLength();
            entity.Property(e => e.CountryName).HasDefaultValueSql("(NULL)");

            entity.HasOne(d => d.Region).WithMany(p => p.Countries).HasConstraintName("FK__countries__regio__1EF99443");
        });

        modelBuilder.Entity<Department>(entity =>
        {
            entity.HasKey(e => e.DepartmentId).HasName("PK__departme__C22324222B28D6C0");

            entity.Property(e => e.LocationId).HasDefaultValueSql("(NULL)");

            entity.HasOne(d => d.Location).WithMany(p => p.Departments)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__departmen__locat__2C538F61");
        });

        modelBuilder.Entity<Dependent>(entity =>
        {
            entity.HasKey(e => e.DependentId).HasName("PK__dependen__F25E28CE0B9D5581");

            entity.HasOne(d => d.Employee).WithMany(p => p.Dependents).HasConstraintName("FK__dependent__emplo__37C5420D");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.EmployeeId).HasName("PK__employee__C52E0BA8210AF5C7");

            entity.Property(e => e.DepartmentId).HasDefaultValueSql("(NULL)");
            entity.Property(e => e.FirstName).HasDefaultValueSql("(NULL)");
            entity.Property(e => e.ManagerId).HasDefaultValueSql("(NULL)");
            entity.Property(e => e.PhoneNumber).HasDefaultValueSql("(NULL)");

            entity.HasOne(d => d.Department).WithMany(p => p.Employees)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__employees__depar__33F4B129");

            entity.HasOne(d => d.Job).WithMany(p => p.Employees).HasConstraintName("FK__employees__job_i__33008CF0");

            entity.HasOne(d => d.Manager).WithMany(p => p.InverseManager).HasConstraintName("FK__employees__manag__34E8D562");
        });

        modelBuilder.Entity<Job>(entity =>
        {
            entity.HasKey(e => e.JobId).HasName("PK__jobs__6E32B6A52A0E8D03");

            entity.Property(e => e.MaxSalary).HasDefaultValueSql("(NULL)");
            entity.Property(e => e.MinSalary).HasDefaultValueSql("(NULL)");
        });

        modelBuilder.Entity<Location>(entity =>
        {
            entity.HasKey(e => e.LocationId).HasName("PK__location__771831EA54647805");

            entity.Property(e => e.CountryId).IsFixedLength();
            entity.Property(e => e.PostalCode).HasDefaultValueSql("(NULL)");
            entity.Property(e => e.StateProvince).HasDefaultValueSql("(NULL)");
            entity.Property(e => e.StreetAddress).HasDefaultValueSql("(NULL)");

            entity.HasOne(d => d.Country).WithMany(p => p.Locations).HasConstraintName("FK__locations__count__24B26D99");
        });

        modelBuilder.Entity<Region>(entity =>
        {
            entity.HasKey(e => e.RegionId).HasName("PK__regions__01146BAE31867698");

            entity.Property(e => e.RegionName).HasDefaultValueSql("(NULL)");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
