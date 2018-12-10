using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PortFolio2017.Enums;

namespace PortFolio2017.Models {
    [Table ("Work")]
    public class Work : BaseClass {
        [Column ("Title")]
        [Required (ErrorMessage = "Please provide Title")]
        public string Title { get; set; }

        [Column ("URLId")]
        [ForeignKey("URL")]
        public Guid URLId { get; set; }
        public virtual URL URL { get; set; }
        [Column("Description")]
        public string Description { get; set; }
        [Column("From")]
        public DateTime From { get; set; }
        [Column("To")]
        public DateTime To { get; set; }
        [Column("CurrentlyEmployed")]
        public bool CurrentlyEmployed { get; set; }
        [Column("LifeEvent")]
        public LifeEvent LifeEvent { get; set; } = LifeEvent.WorkDetails;
    }
}