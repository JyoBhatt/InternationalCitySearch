using InternationalCitySearch.Services;
using InternationalCitySearch.Services._3rd_party_Interfaces;
using InternationCitySearch.Repository;
using InternationCitySearch.Repository.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace InternationalCitySearch.Configuration
{
    public static class DependencyInjection
    {
        public static void ConfigureCityServices(this IServiceCollection services)
        {
            services.AddScoped<ICityFinder, CityFinder>();
            services.AddScoped<ICityResult, CityResult>();
        }

        public static void ConfigureCityRepository(this IServiceCollection repositories)
        {
            repositories.AddScoped<ICityRepository, CityRepository>();
        }
    }
}