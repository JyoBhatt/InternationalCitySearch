using FluentAssertions;
using InternationalCitySearch.Models;
using InternationalCitySearch.Services._3rd_party_Interfaces;
using InternationalCitySearch.Services.Tests.Data;
using InternationCitySearch.Repository;
using InternationCitySearch.Repository.Interfaces;
using NUnit.Framework;

namespace InternationalCitySearch.Services.Tests
{
    public class CityFinderTests
    {
        private ICityFinder _cityFinder;
        private ICityRepository _cityRepository;

        [SetUp]
        public void Setup()
        {
            _cityRepository = new CityRepository();
            _cityFinder = new CityFinder(_cityRepository);
        }

        [TestCase("BANG")]
        public void CityFinder_Search_TestForBANG(string searchString)
        {
            // Arrange
            var expectedResult = CityData.GetCitiesForInputBANG();

            // Act
            var actualResult = _cityFinder.Search(searchString);

            // Assert
            actualResult.Should().NotBeNull();
            actualResult.NextCities.SequenceEqual(expectedResult.NextCities);
            actualResult.Nextletters.SequenceEqual(expectedResult.Nextletters);
        }

        [TestCase("LA")]
        public void CityFinder_Search_TestForLA(string searchString)
        {
            // Arrange
            var expectedResult = CityData.GetCitiesForInputLA();

            // Act
            var actualResult = _cityFinder.Search(searchString);

            // Assert
            actualResult.Should().NotBeNull();
            actualResult.NextCities.SequenceEqual(expectedResult.NextCities);
            actualResult.Nextletters.SequenceEqual(expectedResult.Nextletters);
        }

        [TestCase("ZE")]
        public void CityFinder_Search_TestForZE(string searchString)
        {
            // Arrange
            var expectedResult = CityData.GetCitiesForInputZE();

            // Act
            var actualResult = _cityFinder.Search(searchString);

            // Assert
            actualResult.Should().NotBeNull();
            actualResult.NextCities.SequenceEqual(expectedResult.NextCities);
            actualResult.Nextletters.SequenceEqual(expectedResult.Nextletters);
        }
    }
}
