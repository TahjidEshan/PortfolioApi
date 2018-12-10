using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PortFolio2017.Models {
    [Table("URL")]
    public class URL : BaseClass {
        [Column ("Link")]
        [Required (ErrorMessage = "Link is Required")]
        [StringLength (50, MinimumLength = 2)]
        public string Link { get; set; }

        [Column ("Text")]
        public string Text { get; set; }

        [Column ("Logo")]
        public string Logo { get; set; }
    }
}