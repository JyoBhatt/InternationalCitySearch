using InternationalCitySearch.Services;
using InternationalCitySearch.Services._3rd_party_Interfaces;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace InternationalCitySearch.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CityController : ControllerBase
    {
        internal const string CitySearch = "City Search";
        private readonly ICityFinder _cityFinder;

        public CityController(
            ILogger<CityController> logger,
            ICityFinder cityFinder)
        {
            _cityFinder = cityFinder;
        }

        /// <summary>
        /// List matching cities
        /// </summary>
        /// <param name="searchString"></param>
        /// <returns></returns>
        [SwaggerOperation(Tags = new[] { CitySearch }, Description = "Search Cities")]
        [SwaggerResponse(200, "search results matching criteria", typeof(CityResult))]
        [HttpGet]
        public IActionResult GetCities(string searchString)
        {
            try
            {
                var result = _cityFinder.Search(searchString);
                return Ok(result);
            }
            catch (InvalidOperationException ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}