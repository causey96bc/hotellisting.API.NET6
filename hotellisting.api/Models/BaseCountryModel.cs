using System.ComponentModel.DataAnnotations;

namespace hotellisting.api.Models
{
    public abstract class BaseCountryModel
    {
        [Required]
        public string Name { get; set; }
        public string ShortName { get; set; }

    }
}
