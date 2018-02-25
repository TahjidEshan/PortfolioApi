using System.ComponentModel.DataAnnotations;

namespace PortFolio2017.Models
{
    public class Email : BaseClass
    {
        [Required(ErrorMessage = "Please provide a Valid Email Address.")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string EmailAddress { get; set; }
    }
}
