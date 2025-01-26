using System.Reflection;
using AgriculturalSalesChain.Application.Profiles;
using Microsoft.Extensions.DependencyInjection;

namespace AgriculturalSalesChain.Application;

public static class ApplicationServicesRegistration
{
    public static void ConfigureApplicationServices(this IServiceCollection services)
    {
        //services.AddAutoMapper(typeof(MappingProfile));
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
    }
}