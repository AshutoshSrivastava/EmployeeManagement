using EmployeeManagement.Models;
using EmployeeManagement.Web.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Web.Pages
{
    public class EmployeeListBase : ComponentBase
    {
        [Inject]
        public IEmployeeService EmployeeService { get; set; }
        public IEnumerable<Employee> Employees { get; set; }
        public bool ShowFooter { get; set; } = true;
        public int SelectedEmployeesCount { get; set; } = 0;
        protected override async Task OnInitializedAsync()
        {
            //LoadEmployees();
            Employees = (await EmployeeService.GetEmployees()).ToList();
            //return base.OnInitializedAsync();
        }
        protected void EmployeeSelectionChanged(bool isSelected) {
            if (isSelected)
            {
                SelectedEmployeesCount++;
            }
            else {
                SelectedEmployeesCount--;
            }
        }

        protected async Task EmployeeDeleted(int Id)
        {
            Employees = (await EmployeeService.GetEmployees()).ToList();
        }

        /*
        private void LoadEmployees() {
            Employee e1 = new Employee
            {
                EmployeeId = 1,
                FirstName = "Gardon",
                LastName = "Ramsey",
                DateOfBirth = new DateTime(1992, 1, 1),
                Email = "gramsey@testmail.com",
                Gender = Gender.Male,
                DepartmentId = 1,
                PhotoPath = "https://picsum.photos/200/151"
            };
            Employee e2 = new Employee
            {
                EmployeeId = 2,
                FirstName = "Ross",
                LastName = "Taylor",
                DateOfBirth = new DateTime(1992, 1, 1),
                Email = "rtaylor@testmail.com",
                Gender = Gender.Male,
                DepartmentId = 1,
                PhotoPath = "https://picsum.photos/200/152"
            };
            Employee e3 = new Employee
            {
                EmployeeId = 3,
                FirstName = "Tim",
                LastName = "Coery",
                DateOfBirth = new DateTime(1992, 1, 1),
                Email = "tcoery@testmail.com",
                Gender = Gender.Male,
                DepartmentId = 2,
                PhotoPath = "https://picsum.photos/201/150"
            };
            Employee e4 = new Employee
            {
                EmployeeId = 4,
                FirstName = "Jeff",
                LastName = "Jonson",
                DateOfBirth = new DateTime(1992, 1, 1),
                Email = "jjonson@testmail.com",
                Gender = Gender.Male,
                DepartmentId = 2,
                PhotoPath = "https://picsum.photos/202/150"
            };
            Employee e5 = new Employee
            {
                EmployeeId = 5,
                FirstName = "Sita",
                LastName = "Sahay",
                DateOfBirth = new DateTime(1992, 1, 1),
                Email = "ssahay@testmail.com",
                Gender = Gender.Female,
                DepartmentId = 1,
                PhotoPath = "https://picsum.photos/201/151"
            };

            Employees = new List<Employee> { e1, e2, e3, e4, e5 };
        }
        */
    }
}
