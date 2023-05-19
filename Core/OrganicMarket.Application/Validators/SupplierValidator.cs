using FluentValidation;
using OrganicMarket.Domain.Entities;

namespace OrganicMarket.Application.Validators;

public class SupplierValidator : AbstractValidator<Supplier>
{
    public SupplierValidator()
    {
        RuleFor(s => s.Description)
            .NotEmpty()
            .NotNull()
            .WithMessage("Satıcı Açıklaması boş olamaz.")
            .MinimumLength(5)
            .WithMessage("Satıcı Açıklaması çok kısa")
            .MaximumLength(70)
            .WithMessage("Satıcı Açıklaması çok uzun.");

        RuleFor(s => s.Name)
            .NotEmpty()
            .NotNull()
            .WithMessage("Satıcı İsmi Açıklaması boş olamaz.")
            .MinimumLength(5)
            .WithMessage("Satıcı İsmi Açıklaması çok kısa")
            .MaximumLength(70)
            .WithMessage("Satıcı İsmi Açıklaması çok uzun.");
    }
}
