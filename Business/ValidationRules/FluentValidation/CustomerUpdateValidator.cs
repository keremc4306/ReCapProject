using Entities.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CustomerUpdateValidator:AbstractValidator<CustomerDetailDto>
    {
        public CustomerUpdateValidator()
        {
            RuleFor(customerDetail => customerDetail.Id).NotEmpty();
            RuleFor(customerDetail => customerDetail.FirstName).NotEmpty();
            RuleFor(customerDetail => customerDetail.LastName).NotEmpty();
            RuleFor(customerDetail => customerDetail.Email).NotEmpty();
        }
    }
}
