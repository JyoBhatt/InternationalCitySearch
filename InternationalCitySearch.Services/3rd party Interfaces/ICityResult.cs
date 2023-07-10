namespace InternationalCitySearch.Services._3rd_party_Interfaces
{
    public interface ICityResult
    {
        /// <summary>
        ///  Next letters based on input
        /// </summary>
        ICollection<string> Nextletters { get; set; }

        /// <summary>
        /// Next cities based on input
        /// </summary>
        ICollection<string> NextCities { get; set; }
    }
}
