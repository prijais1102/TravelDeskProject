using Azure.Core;
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
        modelBuilder.Entity<Project>().HasData(
            new() { ProjectId = 1, ProjectName = "GBS-UK" },
            new() { ProjectId = 2, ProjectName = "GBS-Dubai" },
            new() { ProjectId = 3, ProjectName = "GBS-Noida" });
        modelBuilder.Entity<MealPreferenceType>().HasData(
            new() { MealPreferenceTypeId = 1, MealPreferenceName = "Veg" },
            new() { MealPreferenceTypeId = 2, MealPreferenceName = "Non-Veg" }
            );
        modelBuilder.Entity<MealType>().HasData(
            new() { MealTypeId = 1, MealTypeName = "Lunch" },
             new() { MealTypeId = 2, MealTypeName = "Dinner" },
              new() { MealTypeId = 3, MealTypeName = "Both" });
        modelBuilder.Entity<Booking>().HasData(
            new() { BookingId = 1, BookingTypeName = "Air ticket Only" },
             new() { BookingId = 2, BookingTypeName = "Hotel Only" },
              new() { BookingId = 3, BookingTypeName = "Both" });
        modelBuilder.Entity<FlightType>().HasData(
            new() { FlightTypeId = 1, FlightTypeName = "Domestic" },
             new() { FlightTypeId = 2, FlightTypeName = "International" });
        modelBuilder.Entity<Status>().HasData(
            new() { StatusId = 1, StatusName = "Pending" },
            new() { StatusId = 2, StatusName = "Rejected" },
            new() { StatusId = 3, StatusName = "Approved" });
        modelBuilder.Entity<Location>().HasData(
            new() { LocationId = 1, City = "Noida", Country = "India" },
            new() { LocationId = 2, City = "Pune", Country = "India" },
            new() { LocationId = 3, City = "London", Country = "England" },
            new() { LocationId = 4, City = "Dubai", Country = "United Arab Emirates" });

        modelBuilder.Entity<Department>().HasData(
        new() { DepartmentId = 1, DepartmentName = "IT" },
        new() { DepartmentId = 2, DepartmentName = "Sales" },
        new() { DepartmentId = 3, DepartmentName = "HR" });
        modelBuilder.Entity<Role>().HasData(
       new() { RoleId = 1, RoleName = "Admin" },
       new() { RoleId = 2, RoleName = "HRAdmin" },
       new() { RoleId = 3, RoleName = "Employee" },
       new() { RoleId = 4, RoleName = "Manager" });

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
                ManagerId = null
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
    public DbSet<Booking> Bookings { get; set; }
    public DbSet<FlightType> FlightTypes { get; set; }
    public DbSet<Location> Locations { get; set; }
    public DbSet<MealPreferenceType> MealPreferenceTypes { get; set;}
    public DbSet<MealType> MealTypes { get; set; }
    public DbSet<Project> Projects { get; set; }
    public DbSet<Request> Requests { get; set; }
    public DbSet<Status> Statuss { get; set; }

}