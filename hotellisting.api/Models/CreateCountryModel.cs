using System.ComponentModel.DataAnnotations;

namespace hotellisting.api.Data
{
    public class CreateCountryModel
    {
        [Required]
        public string Name { get; set; }
        public string ShortName { get; set; } 
    }
}
