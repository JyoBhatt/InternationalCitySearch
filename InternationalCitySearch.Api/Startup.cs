using InternationalCitySearch.Configuration;

namespace InternationalCitySearch.Api
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.ConfigureCityRepository();
            services.ConfigureCityServices();
        }
    }
}
