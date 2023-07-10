namespace InternationCitySearch.Repository.Interfaces
{
    public interface ICityRepository
    {
        /// <summary>
        /// Get Cities - database filtering for faster search
        /// </summary>
        /// <param name="searchString"></param>
        /// <returns></returns>
        IList<string> GetCities(string searchString);

        /// <summary>
        /// Next city letters
        /// </summary>
        /// <param name="searchString"></param>
        /// <returns></returns>
        IList<string> GetNextCityLetters(string searchString);
    }
}
