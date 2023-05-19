using FluentValidation;
using OrganicMarket.Domain.Entities.Identity;

namespace OrganicMarket.Application.Validators;

public class AppUserValidator : AbstractValidator<AppUser>
{
    public AppUserValidator()
    {
        RuleFor(u => u.FirstName)
            .NotEmpty()
            .NotNull()
            .WithMessage("Ad alanı boş olamaz.")
            .MaximumLength(50)
            .WithMessage("Ad çok uzun.")
            .MinimumLength(3)
            .WithMessage("Ad çok kısa.");

        RuleFor(u => u.LastName)
            .NotEmpty()
            .NotNull()
            .WithMessage("Soyad alanı boş olamaz.")
            .MaximumLength(50)
            .WithMessage("Soyad çok uzun.")
            .MinimumLength(3)
            .WithMessage("Soyad çok kısa.");

        RuleFor(u => u.Email)
            .NotEmpty()
            .NotNull()
            .WithMessage("Email alanı boş olamaz.")
            .EmailAddress()
            .WithMessage("Geçerli bir email adresi giriniz.");
            //.Must(email => email.EndsWith("@example.com")).WithMessage("E-posta adresi example.com uzantısına sahip olmalıdır.");

        RuleFor(u => u.PhoneNumber)
            .NotEmpty()
            .NotNull()
            .WithMessage("Telefon alanı boş olamaz.")
            .Length(10)
            .WithMessage("Geçerli bir formatta girin. Örnek: 555 999 99 99")
            .Matches("^[0-9]*$")
            .WithMessage("Telefon numarası yalnızca rakamlardan oluşmalıdır.");
            //.Matches(@"^\+\d{1,3} \d{3} \d{3} \d{2} \d{2}$").WithMessage("Geçerli bir telefon numarası formatı kullanın. Örnek: +90 555 123 45 67");
    }
}
