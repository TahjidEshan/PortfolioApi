using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PortFolio2017.Models
{
    public class Author : BaseClass
    {
        [Required(ErrorMessage = "Please provide Name.")]
        [StringLength(50, MinimumLength = 2)]
        public string Name { get; set; }
        public string Url { get; set; }
        [ForeignKey("User")]
        public long? UserId { get; set; }
        public virtual User User { get; set; }
    }
}
