using FluentValidation;
using FluentValidation.Validators;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DigiHub.Application.Categories.Commands.CreateCategory
{
    class CreateCategoryCommandValidator : AbstractValidator<CreateCategoryCommand>
    {
        public CreateCategoryCommandValidator()
        {
            RuleFor(c => c.CategoryName)
                .MaximumLength(200)
                .NotEmpty();
            RuleFor(c => c.ParentId)
                .NotNull();
        }
    }
}
