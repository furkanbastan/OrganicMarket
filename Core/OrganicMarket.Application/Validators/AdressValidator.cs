using FluentValidation;
using OrganicMarket.Domain.Entities;

namespace OrganicMarket.Application.Validators;

public class AdressValidator : AbstractValidator<Adress>
{
    public AdressValidator()
    {
        RuleFor(a => a.Title)
            .NotEmpty()
            .NotNull()
            .WithMessage("Adres Başlığı boş olamaz.")
            .MaximumLength(50)
            .WithMessage("Adres Başlığı çok uzun.")
            .MinimumLength(3)
            .WithMessage("Adres Başlığı çok kısa.");

        RuleFor(a => a.City)
            .NotEmpty()
            .NotNull()
            .WithMessage("Şehir alanı boş olamaz.")
            .MaximumLength(50)
            .WithMessage("Şehir ismi çok uzun.")
            .MinimumLength(3)
            .WithMessage("Şehir ismi çok kısa.");

        RuleFor(a => a.District)
            .NotEmpty()
            .NotNull()
            .WithMessage("İlçe alanı boş olamaz.")
            .MaximumLength(50)
            .WithMessage("İlçe ismi çok uzun.")
            .MinimumLength(3)
            .WithMessage("İlçe ismi çok kısa.");

        RuleFor(a => a.Neighbourhood)
            .NotEmpty()
            .NotNull()
            .WithMessage("Mahalle alanı boş olamaz.")
            .MaximumLength(50)
            .WithMessage("Mahalle ismi çok uzun.")
            .MinimumLength(3)
            .WithMessage("Mahalle ismi çok kısa.");

        RuleFor(a => a.PostCode)
            .NotEmpty()
            .NotNull()
            .WithMessage("Posta Kodu alanı boş olamaz.");

    }
}
