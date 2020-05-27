using CourseLibrary.API.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseLibrary.API.Validators
{
    public class CourseForCreationValidator : AbstractValidator<CourseForCreationDto>
    {
        public CourseForCreationValidator()
        {
            RuleFor(c => c.Title)
                .NotEqual(c => c.Description).WithMessage("The provided description should be different from the title.");
        }
    }
}
