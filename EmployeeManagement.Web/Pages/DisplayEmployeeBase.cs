﻿using EmployeeManagement.Models;
using EmployeeManagement.Web.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Web.Pages
{
    public class DisplayEmployeeBase : ComponentBase
    {
        [Parameter]
        public Employee Employee { get; set; }

        [Parameter]
        public bool ShowFooter { get; set; }

        [Parameter]
        public EventCallback<bool> OnEmployeeSelection { get; set; }
        
        [Parameter]
        public EventCallback<int> OnEmployeeDeleted { get; set; }

        [Inject]
        public EmployeeService EmployeeService { get; set; }
        public bool IsSelected { get; private set; }

        protected async Task CheckBoxChanged(ChangeEventArgs e)
        {
            IsSelected = (bool)e.Value;
            await OnEmployeeSelection.InvokeAsync(IsSelected);
        }

        protected async Task Delete_Click()
        {
            await EmployeeService.DeleteEmployee(Employee.EmployeeId);
            await OnEmployeeDeleted.InvokeAsync(Employee.EmployeeId);
        }

    }
}
