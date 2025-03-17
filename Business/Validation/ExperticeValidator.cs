using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Concrete;
using FluentValidation;

namespace Business.Validation
{
    public class ExperticeValidator : AbstractValidator<Expertice>
    {
        public ExperticeValidator()
        {
            RuleFor(x => x.uzmanlikFoto).NotEmpty().WithMessage("Sadece Jpg,Png Yüklenebilir. ");
        }
    }
}
