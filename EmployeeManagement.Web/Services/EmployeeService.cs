using EmployeeManagement.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace EmployeeManagement.Web.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly HttpClient httpClient;

        public EmployeeService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<Employee> GetEmployee(int id)
        {
            return await httpClient.GetJsonAsync<Employee>($"api/employees/{id}");
        }

        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            return await httpClient.GetJsonAsync<Employee[]>("api/employees");
        }

        public async Task<Employee> UpdateEmployee(Employee updateEmployee)
        {
            return await httpClient.PutJsonAsync<Employee>($"api/employees", updateEmployee);
        }

        public async Task<Employee> CreateEmployee(Employee newEmployee)
        {
            return await httpClient.PutJsonAsync<Employee>($"api/employees", newEmployee);
        }

        public async Task DeleteEmployee(int Id) 
        {
            await httpClient.DeleteAsync($"api/employees/{Id}");
        }
    }
}
