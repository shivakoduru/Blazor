﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EmployeeManagement.Models.CustomValidator
{
    public class EmailDomainValidation: ValidationAttribute
    {
        public string AllowedDomain { get; set; }

        protected override ValidationResult IsValid(object value,
            ValidationContext validationContext)
        {
            if (value != null)
            {
                string[] strings = value.ToString().Split('@');
                if (strings.Length > 1 && strings[1].ToUpper() == AllowedDomain.ToUpper())
                {
                    return null;
                }

                return new ValidationResult($"Domain must be {AllowedDomain}",
                new[] { validationContext.MemberName });
                //OR which can be passed with attribute.
                //return new ValidationResult(ErrorMessage,
                //new[] { validationContext.MemberName });
            }
            return null;
        }
    }
}
