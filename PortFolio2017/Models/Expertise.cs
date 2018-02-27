using System.ComponentModel.DataAnnotations;

namespace PortFolio2017.Models
{
    public class Expertise : BaseClass
    {
        [Required(ErrorMessage = "Please provide Title")]
        public string Title { get; set; }
        public string Details { get; set; }
    }
}
