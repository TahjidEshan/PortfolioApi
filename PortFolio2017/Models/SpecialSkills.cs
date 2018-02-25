using PortFolio2017.Enums;
using System.ComponentModel.DataAnnotations;

namespace PortFolio2017.Models
{
    public class SpecialSkills : BaseClass
    {
        public DisplayType DisplayType { get; set; }
        [Required(ErrorMessage = "Please provide title.")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Please provide percentage.")]
        public int Percentage { get; set; }
    }
}
