namespace InternationalCitySearch.Services._3rd_party_Interfaces
{
    public interface ICityFinder
    {
        /// <summary>
        /// Search for cities based on search string
        /// </summary>
        /// <param name="searchString"></param>
        /// <returns></returns>
        ICityResult Search(string searchString);
    }
}
