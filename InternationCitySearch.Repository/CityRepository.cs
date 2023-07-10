using InternationalCitySearch.Models;
using InternationCitySearch.Repository.Interfaces;

namespace InternationCitySearch.Repository
{
    public class CityRepository : ICityRepository
    {
        public CityRepository()
        {
            using var context = new InternationalCitySearchContext();
            var cities = new List<City>()
            {
                new() { Name = "BANDUNG" },
                new() { Name = "BANGUI" },
                new() { Name = "BANGKOK" },
                new() { Name = "BANGALORE" },
                new() { Name = "LA PAZ" },
                new() { Name = "LA PLATA "},
                new() { Name = "LAGOS" },
                new() { Name = "LEEDS" },
                new() { Name = "ZARIA" },
                new() { Name = "ZHUGHAI" },
                new() { Name = "ZIBO" }
            };

            // Load only once in memory
            if (!context.Cities.Any())
            {
                context.Cities.AddRange(cities);
                context.SaveChangesAsync();
            }
        }

        public IList<string> GetCities(string searchString)
        {
            using var context = new InternationalCitySearchContext();
            return context.Cities
                .Where(x => x.Name.StartsWith(searchString.ToUpper()))
                .Select(x => x.Name)
                .Distinct()
                .ToList();
        }

        public IList<string> GetNextCityLetters(string searchString)
        {
            return GetCities(searchString.ToUpper())
                .Select(x => x[searchString.Length].ToString())
                .Distinct()
                .ToList();
        }
    }
}