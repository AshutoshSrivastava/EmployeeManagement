using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EmployeeManagement.Models.CustomValidator
{
    public class EmailDomainValidator : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                //return base.IsValid(value, validationContext);
                string[] strings = value.ToString().Split('@');
                if (strings.Length > 1 && strings[1].ToUpper() == "GMAIL.COM")
                {
                    return null;
                }
                else
                {
                    return new ValidationResult("Email domain should be Gmail.com", new[] { validationContext.MemberName });
                }
            }
            else
                return null;
        }
    }
}
