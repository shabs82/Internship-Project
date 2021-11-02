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
        public UserValidator()
        {
            RuleFor(p => p.Username).MaximumLength(50).WithMessage("name cannot be more than 50 characters");
            RuleFor(p => p.Username).MinimumLength(5).WithMessage("name cannot be less than 5 characters");
            RuleFor(p => p.Username).NotNull().WithMessage("username cannot be empty");
            RuleFor(p => p.Username).Null().WithMessage("username already taken");
            RuleFor(p => p.Username).Matches("(**?:[^​˜!#$]*[˜​!#$]**)").WithMessage("special characters not allowed in username");
           
            
        }
       
    }
}
