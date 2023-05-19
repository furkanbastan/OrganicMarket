using FluentValidation;
using OrganicMarket.Domain.Entities;

namespace OrganicMarket.Application.Validators;

public class ProductValidator : AbstractValidator<Product>
{
    public ProductValidator()
    {
        RuleFor(p => p.Description)
            .NotEmpty()
            .NotNull()
            .WithMessage("Ürün Açıklaması boş olamaz.")
            .MinimumLength(5)
            .WithMessage("Ürün Açıklaması çok kısa")
            .MaximumLength(70)
            .WithMessage("Ürün Açıklaması çok uzun.");

        RuleFor(p => p.Name)
            .NotEmpty()
            .NotNull()
            .WithMessage("Ürün İsmi boş olamaz.")
            .MinimumLength(5)
            .WithMessage("Ürün İsmi çok kısa")
            .MaximumLength(70)
            .WithMessage("Ürün İsmi çok uzun.");

        RuleFor(p => p.Price)
            .NotEmpty()
            .NotNull()
            .WithMessage("Ürün Fiyatı boş olamaz.")
            .GreaterThanOrEqualTo(0)
            .WithMessage("Ürün Fiyatı negatif olamaz.");
    }
}
