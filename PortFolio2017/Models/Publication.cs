using PortFolio2017.Enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PortFolio2017.Models
{
    public class Publication : BaseClass
    {
        [Required(ErrorMessage = "Please provide House Number.")]
        [StringLength(50, MinimumLength = 2)]
        public string Name { get; set; }
        public string Url { get; set; }
        public string UrlText { get; set; }
        public string Description { get; set; }
        public LifeEvent LifeEvent { get; set; } = LifeEvent.Publication;
    }
}
