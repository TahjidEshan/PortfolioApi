using System.ComponentModel.DataAnnotations;

namespace PortFolio2017.Models
{
    public class GeneralSkill : BaseClass
    {
        [Required(ErrorMessage = "Please provide Title")]
        public string Text { get; set; }
        [Required(ErrorMessage = "Please provide Percentage")]
        public int Percentage { get; set; }
    }
}
