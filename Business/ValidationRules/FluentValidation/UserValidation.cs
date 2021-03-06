﻿using Core.Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidation :AbstractValidator<User>
    {
        public UserValidation()
        {
            RuleFor(p => p.FirstName).MinimumLength(2);
            RuleFor(p => p.LastName).MinimumLength(2);
            RuleFor(p => p.Email).NotEmpty();
            //RuleFor(p => p.PasswordSalt).MinimumLength(6);
        }
    }
}
