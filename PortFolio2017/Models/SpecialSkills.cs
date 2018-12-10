using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PortFolio2017.Enums;

namespace PortFolio2017.Models {
    [Table ("SpecialSkills")]
    public class SpecialSkills : BaseClass {
        [Column ("DisplayType")]
        public DisplayType DisplayType { get; set; }

        [Required (ErrorMessage = "Please provide title.")]
        [Column ("Title")]
        public string Title { get; set; }

        [Column ("Percentage")]
        [Required (ErrorMessage = "Please provide percentage.")]
        public double Percentage { get; set; }
    }
}