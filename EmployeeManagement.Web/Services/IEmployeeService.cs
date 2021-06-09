using EmployeeManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Web.Services
{
    public interface IEmployeeService
    {
        Task<IEnumerable<Employee>> GetEmployees();
        Task<Employee> GetEmployee(int Id);
        Task<Employee> UpdateEmployee(Employee updateEmployee);
        Task<Employee> CreateEmployee(Employee newEmployee);
        Task DeleteEmployee(int Id);
    }
}
