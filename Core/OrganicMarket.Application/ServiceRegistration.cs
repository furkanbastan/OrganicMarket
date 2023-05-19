using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;
using OrganicMarket.Application.Mappers;
using OrganicMarket.Application.Validators;

namespace OrganicMarket.Application;

public static class ServiceRegistration
{
    public static void AddApplicationServices(this IServiceCollection services)
    {
        services.AddFluentValidationAutoValidation(opt =>
            {
                opt.DisableDataAnnotationsValidation = true;
                //opt.ValidatorOptions.LanguageManager.Culture = new CultureInfo("tr");
            })
            .AddValidatorsFromAssemblyContaining<AppUserValidator>();

        services.AddAutoMapper(typeof(AppUserProfile));
    }
}
