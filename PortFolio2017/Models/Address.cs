using System.ComponentModel.DataAnnotations;

namespace PortFolio2017.Models
{
    public class Address : BaseClass
    {
        [Required(ErrorMessage = "Please provide House Number.")]
        [StringLength(50, MinimumLength = 2)]
        public string HouseNumber { get; set; }
        [Required(ErrorMessage = "Please provide Road Number.")]
        [StringLength(50, MinimumLength = 2)]
        public string RoadNumber { get; set; }
        [Required(ErrorMessage = "Please provide Name of the City.")]
        [StringLength(50, MinimumLength = 2)]
        public string City { get; set; }
        [Required(ErrorMessage = "Please provide Name of the Country.")]
        [StringLength(50, MinimumLength = 2)]
        public string Country { get; set; }
    }
}
