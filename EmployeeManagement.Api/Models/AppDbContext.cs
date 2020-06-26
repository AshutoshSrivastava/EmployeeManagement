using EmployeeManagement.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Api.Models
{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
            // ...
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            ////Seed Departments Table
            //modelBuilder.Entity<Department>().HasData(
            //    new Department { DepartmentId = 1, DepartmentName = "IT" });
            //modelBuilder.Entity<Department>().HasData(
            //    new Department { DepartmentId = 2, DepartmentName = "HR" });
            //modelBuilder.Entity<Department>().HasData(
            //    new Department { DepartmentId = 3, DepartmentName = "Payroll" });
            //modelBuilder.Entity<Department>().HasData(
            //    new Department { DepartmentId = 4, DepartmentName = "Admin" });

            //// Seed Employee Table
            //modelBuilder.Entity<Employee>().HasData(new Employee
            //{
            //    EmployeeId = 1,
            //    FirstName = "John",
            //    LastName = "Hastings",
            //    Email = "David@testmail.com",
            //    DateOfBirth = new DateTime(1980, 10, 5),
            //    Gender = Gender.Male,
            //    DepartmentId = 1,
            //    PhotoPath = "images/emp1.jpg"
                
            //});

            //modelBuilder.Entity<Employee>().HasData(new Employee
            //{
            //    EmployeeId = 2,
            //    FirstName = "Sam",
            //    LastName = "Galloway",
            //    Email = "Sam@testmail.com",
            //    DateOfBirth = new DateTime(1981, 12, 22),
            //    Gender = Gender.Male,
            //    DepartmentId = 2,
            //    PhotoPath = "images/emp2.jpg"
            //});

            //modelBuilder.Entity<Employee>().HasData(new Employee
            //{
            //    EmployeeId = 3,
            //    FirstName = "Mary",
            //    LastName = "Smith",
            //    Email = "mary@testmail.com",
            //    DateOfBirth = new DateTime(1979, 11, 11),
            //    Gender = Gender.Female,
            //    DepartmentId = 1,
            //    PhotoPath = "images/emp3.jpg"
            //});

            //modelBuilder.Entity<Employee>().HasData(new Employee
            //{
            //    EmployeeId = 4,
            //    FirstName = "Sara",
            //    LastName = "Longway",
            //    Email = "sara@testmail.com",
            //    DateOfBirth = new DateTime(1982, 9, 23),
            //    Gender = Gender.Female,
            //    DepartmentId = 3,
            //    PhotoPath = "images/emp4.jpg"
            //});
        }
    }
}
