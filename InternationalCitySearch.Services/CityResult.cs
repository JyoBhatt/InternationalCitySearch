using InternationalCitySearch.Services._3rd_party_Interfaces;

namespace InternationalCitySearch.Services
{
    public class CityResult : ICityResult
    {
        public ICollection<string> Nextletters { get; set; }
        public ICollection<string> NextCities { get; set; }
    }
}
