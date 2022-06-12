using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLayer.ValidationRules
{
    public class BlogValidator:AbstractValidator<Blog>
    {
        public BlogValidator()
        {
            RuleFor(x => x.BlogTitle).NotEmpty().WithMessage("Blog title not empty");
            RuleFor(x => x.BlogContent).NotEmpty().WithMessage("Blog content not empty");
            RuleFor(x => x.BlogImage).NotEmpty().WithMessage("Blog image not empty");
            RuleFor(x => x.BlogTitle).MaximumLength(100).WithMessage("Please Blog title minumum enter 100 caracter");
            RuleFor(x => x.BlogTitle).MinimumLength(5).WithMessage("Please Writer Name maximum enter 5 caracter");
        }
    }
}
