using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Runtime.InteropServices;
using TravelDeskProject.Models;

public class TravelDbContext : DbContext
{
    //public TravelDbContext()
    //{

    //}
    public TravelDbContext(DbContextOptions<TravelDbContext> options) : base(options) { }

    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //{
    //    optionsBuilder.UseSqlServer("data source=(localdb)\\MSSQLLocalDB;initial catalog=StuDb;integrated security=true;TrustServerCertificate=true");
    //}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //Seeding Country Master Data using HasData method
            modelBuilder.Entity<Department>().HasData(
            new() { DepartmentId = 1, DepartmentName = "IT" },
            new() { DepartmentId = 2, DepartmentName = "Sales" },
            new() { DepartmentId = 3, DepartmentName = "HR" });
        modelBuilder.Entity<Role>().HasData(
       new() { RoleId = 1, RoleName = "Admin" },
       new() { RoleId = 2, RoleName = "HRAdmin" },
       new() { RoleId = 3, RoleName = "Employee" },
       new() { RoleId = 4, RoleName = "Manager"});

        modelBuilder.Entity<User>().HasData(
            new User
            {
                UserId = 1,
                FirstName = "Priya",
                LastName = "Jaiswal",
                Email = "priya@gmail.com",
                Password = "Priya@123",
                Address = "Mzp",
                MobileNumber = "6306788371",
                CreatedBy = 1,
                CreatedOn = DateTime.Now,
                IsActive = true,
                RoleId = 1,
                DepartmentId = 1,
                ManagerId=null
            },
        new User
        {
            UserId = 2,
            FirstName = "Erica",
            LastName = "Attal",
            Email = "erica@gmail.com",
            Password = "Erica@123",
            Address = "Delhi",
            MobileNumber = "9090909090",
            CreatedBy = 1,
            CreatedOn = DateTime.Now,
            IsActive = true,
            RoleId = 4,
            DepartmentId = 2,
            ManagerId = 1
        });
    }
    public DbSet<Role> Roles { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Department> Departments { get; set; }
}