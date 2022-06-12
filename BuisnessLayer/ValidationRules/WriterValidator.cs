using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLayer.ValidationRules
{
    public class WriterValidator:AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Writer Name not empty");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Writer Mail not empty");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Writer Password not empty");
            RuleFor(x => x.WriterAbout).NotEmpty().WithMessage("Confirm Password not empty");
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("Please Writer Name minumum enter 2 caracter");
            RuleFor(x => x.WriterName).MaximumLength(30).WithMessage("Please Writer Name maximum enter 30 caracter");

        }
    }
}
