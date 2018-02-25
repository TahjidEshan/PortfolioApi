using System.ComponentModel.DataAnnotations;

namespace PortFolio2017.Models
{
    public class Phone : BaseClass
    {
        [Required(ErrorMessage = "Please provide a Valid Phone Number")]
        public string PhoneNumber { get; set; }
    }
}
