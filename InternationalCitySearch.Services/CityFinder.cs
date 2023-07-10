using InternationalCitySearch.Services._3rd_party_Interfaces;
using InternationCitySearch.Repository.Interfaces;

namespace InternationalCitySearch.Services
{
    public class CityFinder : ICityFinder
    {
        private readonly ICityRepository _cityRepository; 

        public CityFinder(ICityRepository cityRepository)
        {
            _cityRepository = cityRepository;
        }

        public ICityResult Search(string searchString)
        {
            var cities = _cityRepository.GetCities(searchString);
            var nextLetters = _cityRepository.GetNextCityLetters(searchString);

            CityResult result = new()
            {
                NextCities = cities,
                Nextletters = nextLetters
            };
            return result;
        }
    }
}