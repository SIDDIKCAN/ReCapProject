using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class ColorValidation:AbstractValidator<Color>
    {
        public ColorValidation()
        {
            RuleFor(p => p.Name).MinimumLength(2).WithMessage("Renk adı en az 2 karakter olmalıdır.");
        }
    }
}
