﻿using FluentValidation;
using Showcase.Admin.WebAPI.Controllers.Companies.Requests;

namespace Showcase.Admin.WebAPI.Controllers.Companies.Validators
{
    public class CompanyAddRequestValidator : AbstractValidator<CompanyAddRequest>
    {
        public CompanyAddRequestValidator()
        {
            RuleFor(x => x.Name).NotEmpty();
            RuleFor(x => x.CoverUrl).NotEmpty().Length(5, 500);
        }
    }
}