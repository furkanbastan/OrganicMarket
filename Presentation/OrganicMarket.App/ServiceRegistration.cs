namespace OrganicMarket.App;

public static class ServiceRegistration
{
    public static void AddAppServices(this IServiceCollection services)
    {
        services.AddRazorPages().AddRazorRuntimeCompilation();
    }
}
