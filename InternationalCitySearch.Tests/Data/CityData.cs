using InternationalCitySearch.Models;

namespace InternationalCitySearch.Services.Tests.Data
{
    public class CityData
    {
        internal static CityResult GetCitiesForInputBANG()
        {
            return new CityResult()
            {
                NextCities = new List<City>()
                {
                    new() { Name = "BANGUI" },
                    new() { Name = "BANGKOK" },
                    new() { Name = "BANGALORE" }
                }
                .Select(X => X.Name).ToList(),
                Nextletters = new List<string>()
                {
                    "U",
                    "K",
                    "A"
                }
            };
        }

        internal static CityResult GetCitiesForInputLA()
        {
            return new CityResult()
            {
                NextCities = new List<City>()
                {
                    new() { Name = "LA PAZ"},
                    new() { Name = "LA PLATA"},
                    new() { Name = "LAGOS"}
                }
                .Select(X => X.Name).ToList(),
                Nextletters = new List<string>()
                {
                    " ",
                    "G",
                }
            };
        }

        internal static CityResult GetCitiesForInputZE()
        {
            return new CityResult()
            {
                NextCities = new List<City>()
                .Select(X => X.Name).ToList(),
                Nextletters = new List<string>()
            };
        }
    }
}
