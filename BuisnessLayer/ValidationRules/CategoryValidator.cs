using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLayer.ValidationRules
{
    public class CategoryValidator:AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Category name not empty");
            RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage("Category description not empty");
            RuleFor(x => x.CategoryName).MaximumLength(50).WithMessage("Please Category name maximum enter 50 caracter");
            RuleFor(x => x.CategoryName).MinimumLength(5).WithMessage("Please Category name minumum enter 5 caracter");
        }  
    }
}
