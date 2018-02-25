using PortFolio2017.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace PortFolio2017.Models
{
    public class Work : BaseClass
    {
        [Required(ErrorMessage = "Please provide Title")]
        public string Title { get; set; }
        public string Url { get; set; }
        public string UrlText { get; set; }
        public string Description { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public bool CurrentlyEmployed { get; set; }
        public LifeEvent LifeEvent { get; set; } = LifeEvent.WorkDetails;
    }
}
