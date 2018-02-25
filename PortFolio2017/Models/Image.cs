using System.ComponentModel.DataAnnotations;

namespace PortFolio2017.Models
{
    public class Image : BaseClass
    {
        [Required(ErrorMessage = "Provide valid Location")]
        public string Location { get; set; }
    }
}
