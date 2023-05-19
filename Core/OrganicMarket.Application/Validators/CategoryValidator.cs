using FluentValidation;
using OrganicMarket.Domain.Entities;

namespace OrganicMarket.Application.Validators;

public class CategoryValidator : AbstractValidator<Category>
{
    public CategoryValidator()
    {
        RuleFor(c => c.Name)
            .NotEmpty()
            .NotNull()
            .WithMessage("Kategori alanı boş olamaz.")
            .MinimumLength(3)
            .WithMessage("Kategori ismi çok kısa")
            .MaximumLength(40)
            .WithMessage("Kategori ismi çok uzun.");
    }
}
