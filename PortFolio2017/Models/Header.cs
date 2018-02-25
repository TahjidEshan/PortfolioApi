using System.ComponentModel.DataAnnotations;

namespace PortFolio2017.Models
{
    public class Header : BaseClass
    {
        [Required(ErrorMessage = "Please provide Title")]
        public string Text { get; set; }
    }
}
