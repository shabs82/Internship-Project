using FluentValidation;
using SafCos.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafCos.Core.AppService.Validators
{
    public class UserValidator : AbstractValidator<User>
    {
       // RuleFor(p => p.Name).MaximumLength(50).WithMessage("name cannot be more than 50 characters");
       // RuleFor(p => p.Name).MinimumLength(3).WithMessage("name cannot be less than 3 characters");
    }
}
