using System.ComponentModel.DataAnnotations.Schema;

namespace InternationalCitySearch.Models
{
    public class City
    {
        /// <summary>
        /// Unique Id for every city
        /// </summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        /// <summary>
        /// City name - indexed to make search faster on name
        /// </summary>
        public string Name { get; set; }
    }
}