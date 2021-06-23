using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ConsoleApp9.Models
{
    public partial class CitiusContext : DbContext
    {
        public CitiusContext()
        {
        }

        public CitiusContext(DbContextOptions<CitiusContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Citius; Integrated Security=True;MultipleActiveResultSets=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>(entity =>
            {
                entity.HasKey(e => e.DeptUniqueId);

                entity.Property(e => e.DeptUniqueId).ValueGeneratedNever();

                entity.Property(e => e.DeptName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeptNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Location)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.EmpUniqueId)
                    .HasName("PK__Employee__F8554A0772270CF8");

                entity.Property(e => e.Designation).HasMaxLength(255);

                entity.Property(e => e.EmpName).HasMaxLength(255);

                entity.Property(e => e.EmpNo)
                    .HasColumnName("EmpNO")
                    .HasMaxLength(255);

                entity.Property(e => e.Salary).HasColumnName("salary");

                entity.HasOne(d => d.DeptUnique)
                    .WithMany(p => p.Employee)
                    .HasForeignKey(d => d.DeptUniqueId)
                    .HasConstraintName("FK_tblDepartment_tblEmployee_DeptID");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
